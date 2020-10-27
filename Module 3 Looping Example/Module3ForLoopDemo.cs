using System;
using static System.Console;

//Name: James Shoemaker
//Date: 04/04/2020
//Progrm Description: Week 3 looping example

namespace Module_3_Looping_Example
{
    class Module3ForLoopDemo
    {
        static void Main(string[] args)
        {
            //Grading Application - Requests 5 grades and then calculates the average
            int grade = 0;
            double total = 0;
            double average = 0.0;
            const int GRADE_COUNT = 5;

            for (int counter = 1; counter <= GRADE_COUNT; counter++)
            {
                Write(" Please enter a grade as an integer: ");
                grade = int.Parse(ReadLine());

                total = total + grade;
            }

            average = total / GRADE_COUNT;
            WriteLine($"the average grade is: {average.ToString("F1")}");
        }
    }
}
