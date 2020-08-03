// Author: Robin Mauritz Languju
// Written in Visual Studio Code, copy pasted to SharpDevelop.

using System;

namespace ConvertFlowchart
{
    class Program
    {
        const string FAILED_MESSAGE = "You've failed";
        const string PASSED_MESSAGE = "You've passed";

        static void Main(string[] args)
        {
            //* Shouldn't have used labels for code readability but... eh, okay.
BEGIN:
            
            //* This one is based on elimination-like algorithm. 
            Console.Write("Write Math Score: ");
            int mathScore = Convert.ToUInt16(Console.ReadLine());

            Console.Write("Write English Score: ");
            int englishScore = Convert.ToUInt16(Console.ReadLine());
            
            Console.Write("Write Algorithm Score: ");
            int algorithmScore = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine();
            
            int avgScore = (mathScore + englishScore + algorithmScore) / 3;
            char predicate = 'F'; //* Add Default value to prevent nullpointerexception. (not that it will occur in this code but hey, it's the thoughts that counts)

            if (avgScore < 60)
                predicate = 'C';
            else 
            if (avgScore < 75)
                predicate = 'B';
            else 
                predicate = 'A';

            if (predicate == 'C')
                Console.WriteLine(FAILED_MESSAGE);
            else
                Console.WriteLine(PASSED_MESSAGE);

            Console.ReadKey(true);
            Console.Clear();

goto BEGIN;
        }
    }
}
