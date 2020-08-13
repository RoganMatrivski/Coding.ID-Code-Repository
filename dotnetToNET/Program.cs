using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace dotnetToNET
{
    class Program
    {
        static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                throw new Exception("Parameter incorrect");
            }
            string baseDir = Directory.GetCurrentDirectory();
            string sourceBaseDir = args[0];
            // string sourceBaseDir = @"Z:\GitRepos\Coding.ID\Day 5\Task";
            string targetBaseDir = Path.Join(sourceBaseDir, "SharpDevelopVer\\");
            string zipFile = Path.Join(baseDir, "./_TEMPLATE_.zip");

            var directories = Directory.GetDirectories(sourceBaseDir);

            foreach (var directory in directories)
            {
                var directoryName = new DirectoryInfo(directory).Name;
                if (directoryName[0] == '.' || directoryName == "_TEMPLATE_" || directoryName == "SharpDevelopVer")
                    continue;

                var splittedName = directoryName.Split(' ');

                string nameResult = ""; //* Project, solution, basically every name generated will be replaced with this.

                for (int i = 0; i < splittedName.Length; i++)
                {
                    var currentWord = splittedName[i];

                    if (i == 0)
                    {
                        nameResult += UppercaseFirst(currentWord);
                    }
                    else
                    {
                        var firstLetter = currentWord[0];
                        nameResult += char.ToUpper(firstLetter);
                    }
                }

                var targetDir = Path.Join(targetBaseDir, nameResult);

                ZipFile.ExtractToDirectory(zipFile, Path.Join(targetBaseDir, nameResult));

                IEnumerable<string> targetFiles = Directory.EnumerateFiles(targetDir, "*.*", SearchOption.AllDirectories);
                foreach (var file in targetFiles)
                {
                    var fileData = File.ReadAllText(file);

                    fileData = fileData.Replace("_TEMPLATE_", nameResult);

                    File.WriteAllText(file, fileData);

                    var fileBaseDir = Path.GetDirectoryName(file);
                    var fileName = Path.GetFileName(file);
                    fileName = fileName.Replace("_TEMPLATE_", nameResult);

                    var finalPath = Path.Join(fileBaseDir, fileName);

                    if (file == finalPath) continue;

                    File.Copy(file, Path.Join(fileBaseDir, fileName));
                    File.Delete(file);
                }

                var targetDirectories = Directory.EnumerateDirectories(targetDir, "*.*", SearchOption.AllDirectories);
                foreach (var dir in targetDirectories)
                {
                    var dirParent = Directory.GetParent(dir).FullName;
                    var dirName = new DirectoryInfo(dir).Name.Replace("_TEMPLATE_", nameResult);
                    var finalPath = Path.Join(dirParent, dirName);

                    if (dir == finalPath) continue;

                    Directory.Move(dir, finalPath);
                }

                var sourceCodePath = Path.Join(directory, "Program.cs");
                var targetPath = Path.Join(targetDir, nameResult, "Program.cs");

                File.Copy(sourceCodePath, targetPath);

                var targetCode = File.ReadAllText(targetPath);
                targetCode = targetCode.Replace("_TEMPLATE_", nameResult);
                File.WriteAllText(targetPath, targetCode);
            }
        }
    }
}
