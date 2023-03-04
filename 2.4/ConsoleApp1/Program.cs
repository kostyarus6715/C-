﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Console.Write("ВВЕДИТЕ РИМСКОЕ ЧИСЛО: ");
            string? roman = Console.ReadLine();
            int result = 0;
            Dictionary<char, int> map = new Dictionary<char, int>()
            {
                {'I', 1 },
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 }
            };
            
            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && map[roman[i]] < map[roman[i + 1]])
                {
                    result -= map[roman[i]];
                }
                else
                {
                    result += map[roman[i]];
                }
            }
            Console.WriteLine("Арабское число: " + result);
        }
    }
}