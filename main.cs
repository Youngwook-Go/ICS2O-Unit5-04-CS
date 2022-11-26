// Created by: Youngwook
// Created on: NOV 2022
//
// This function gets user age and day of the week to answer properly

using System;

class Program
{
    public static void Main(string[] args)
    {
        // input
        int age;
        string day;

        Console.WriteLine("This program gets user age and day of the week to answer properly.\n");

        Console.Write("Enter your age : "); age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the day of the week : "); day = Console.ReadLine();

        // output
        if ((age > 12 && age < 21) || (day == "Tuesday" || day == "Thursday"))
        {
            Console.WriteLine("You get in for free");
        }
        else
        {
            Console.WriteLine("You must pay admission");
        }
        Console.WriteLine("\ndone.");
    }
}
