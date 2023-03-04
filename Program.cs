﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args)
    {
        List<string> employees = new List<string>();
        while (true)
        {
            Console.WriteLine("Please enter a name: ");
            string input = Console.ReadLine() ?? "";
            if (input == "")
            {
                break;
            }
            employees.Add(input);
        }
        
        for(int i = 0; i < employees.Count; i++)
        {
            Console.WriteLine(employees[i]);
        }
    }
  }
}
