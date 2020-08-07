// Copyright 2020, Robin Mauritz Languju, All rights reserved.
// Author: Robin Mauritz Languju
// Written in Visual Studio Code, copy pasted to SharpDevelop.

using System;

namespace ConvertFlowchart1
{
    class Program
    {
        const string FAILED_MESSAGE = "You've failed";
        const string PASSED_MESSAGE = "You've passed";

        static void Main(string[] args)
        {
        //* This one is based on elimination-like algorithm. 

        //* Shouldn't have used labels for code readability but... eh, okay.
        START:
            Console.Write("Write Math Score: ");
            int mathScore = Convert.ToUInt16(Console.ReadLine());

            Console.Write("Write English Score: ");
            int englishScore = Convert.ToUInt16(Console.ReadLine());

            Console.Write("Write Algorithm Score: ");
            int algorithmScore = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine();

            if (algorithmScore < 60)
            {
                Console.WriteLine(FAILED_MESSAGE);
                goto START;
            }

            //* Calculate avgScore if they passed the Algorithm Score
            int avgScore = (mathScore + englishScore + algorithmScore) / 3;

            if (avgScore < 70)
            {
                Console.WriteLine(FAILED_MESSAGE);
                goto START;
            }

            Console.WriteLine(PASSED_MESSAGE);
            goto START;
        }
    }
}
