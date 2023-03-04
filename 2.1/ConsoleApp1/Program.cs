using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Задание 1
            String j = Console.ReadLine();
            String s = Console.ReadLine();
            int res = 0;
            
            foreach (char ch in s)
            {
                if (j.IndexOf(ch) >= 0)
                {
                    res++;
                }
            }
            Console.WriteLine("Камни которые являются драгоценностями: " +res);

            //Задание 2
            // candidates(new int[] {10,1,2,7,6,1,5}, 8);
            // void candidates(int[] arr, int target)
            // {
            //     int tar = target;
            //     int[] stack = new int[arr.Length];
            //     int a = 0;
            //
            //     void comb(int i, int target)
            //     {
            //         if (target == 0)
            //         {
            //             for (int j = 0; j < a; ++j)
            //             {
            //                 Console.Write(stack[j] + " ");
            //             }
            //             Console.WriteLine($" = {tar}");
            //             return;
            //         }
            //
            //         if (i < arr.Length)
            //         {
            //             stack[a++] = arr[i];
            //             comb(i + 1, target - arr[i]);
            //             --a;
            //             comb(i + 1, target);
            //         }
            //     }
            //     comb(0, target);
            // }

            //Задание 3
            //
            // bool function(int[] nums)
            // {
            //     List<int> num = new List<int>();
            //
            //     for (int i = 0; i < nums.Length; i++)
            //     {
            //         if (num.Contains(nums[i]))
            //         {
            //             return true;
            //         }
            //         else
            //         {
            //             num.Add(nums[i]);
            //         }
            //
            //          
            //     }
            //     return false;
            // }
            //
            //
            // int[] nums = { 1, 2, 3, 4 };
            // bool fun = function(nums);
            // Console.WriteLine(fun);
        }
    }
}