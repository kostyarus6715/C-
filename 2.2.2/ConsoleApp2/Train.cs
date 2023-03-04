using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1
{
    public class Train
    {
        public string punkt { get; set; } //Пункт назначения
        public string num { get; set; } //Номер поезда
        public string time { get; set; } //Время отправления

        public void trainInfo()
        {
            Console.WriteLine($"Пункт назначения: {punkt} \n" +
                              $"Номер поезда: {num} \n" +
                              $"Время отправления: {time}\n" +
                              "Нажмите Enter, чтобы продолжить");
            Console.ReadKey();
            Console.Clear();
        }

        public void addAlL()
        {
            Console.Write("Введите пункт назначения: ");
            punkt = Console.ReadLine();

            Console.Write("Введите номер поезда: ");
            num = Console.ReadLine();

            Console.Write("Введите время отправления: ");
            time = Console.ReadLine();
            Console.Clear();
            Console.Write("\n");
        }

        public void tNumber(Train trains)
        {
            Console.Write("Введите номер нужного вам поезда : ");
            String number = Console.ReadLine();
            Console.Clear();
            for (int j = 0; j < 1; j++)
            {
                if (number == num)
                {
                    Console.Write("\nИнформация о вашем поезде\n");
                    trains.trainInfo();
                }
                else
                {
                    Console.Write("Такого поезда нету");
                    Console.ReadKey();
                }
            }
        }
    }
}