using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1
{
    public class Chisla
    {
        public int chislo1 { get; set; } //Число 1
        
        public int chislo2 { get; set; } //Число 2

        public void edit1()
        {
            Console.Write("Введите первое число: ");
            chislo1 = Convert.ToInt32(Console.ReadLine());
            cInfo();
        }
        public void edit2()
        {
            Console.Write("Введите второе число: ");
            chislo2 = Convert.ToInt32(Console.ReadLine());
            cInfo();
        }
        public void addAll()
        {
            Console.Write("Введите первое число: ");
            chislo1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите второе число: ");
            chislo2 = Convert.ToInt32(Console.ReadLine());
        }

        public void cInfo()
        {
            Console.Write($"Первое число: {chislo1}"+
                          $"\nВторое число: {chislo2}"+
                          $"\n Нажмите Enter, чтобы продолжить");
            Console.ReadKey();
        }

        public void summa()
        {
            int a = chislo1 + chislo2;
            Console.Write($"Сумма чисел {chislo1} + {chislo2} = {a}\n"+
                          "Нажмите Enter, чтобы продолжить");
            Console.ReadKey();
        }

        public void sravn()
        {
            Console.Write($"Из введёных чисел {chislo1} и {chislo2}");
            if (chislo1 > chislo2)
            {
                Console.Write($"\n{chislo1} является наибольшим");
            }
            else if (chislo2 > chislo1)
            {
                Console.Write($"\n{chislo2} является наибольшим");
            }
            else
            {
                Console.Write($"\nВведёные числа равны");
            }
            Console.ReadKey();
        }
    }
    
}