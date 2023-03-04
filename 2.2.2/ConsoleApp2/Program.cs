using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Train trains = new Train();
            for (int i = 0; i >= 0; i++)
            {
                Console.Clear();
                Console.Write("Выберите пункт: \n" +
                              "1 - Добавить информацию о поезде \n" +
                              "2 - Посмотреть номер поезда \n" +
                              "3 - Посмотреть информацию по номеру поезда \n" +
                              "4 - Изменение информации\n" +
                              "5 - Выход\n");

                              int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                 case 1:
                     Console.Clear();
                     trains.addAlL();
                     trains.trainInfo();
                     Console.Write("\n");
                     break;
                 case 2:
                     Console.Clear();
                     Console.Write($"Номер введёного поезда: {trains.num} \n");
                     Console.Write("Нажмите Enter, чтобы продолжить");
                     Console.ReadKey();
                     break;
                 case 3:
                     Console.Clear();
                     trains.tNumber(trains);
                     break;
                 case 4:
                     Console.Clear();
                     Console.WriteLine("Выберите пункт \n" +
                                   "1 - Изменить пункт назначения \n" +
                                   "2 - Изменить номер поезда \n" +
                                   "3 - Изменить время отправления");
                     int b = Convert.ToInt32(Console.ReadLine());
                     switch (b)
                     {
                         case 1:
                             Console.Clear();
                             Console.Write("Введите пункт назначения: ");
                             trains.punkt = Console.ReadLine();
                             trains.trainInfo();
                             break;
                         case 2:
                             Console.Clear();
                             Console.Write("Введите номер поезда: ");
                             trains.num = Console.ReadLine();
                             trains.trainInfo();
                             break;
                         case 3:
                             Console.Clear();
                             Console.Write("Введите время отправления: ");
                             trains.time = Console.ReadLine();
                             trains.trainInfo();
                             break;  
                     }
                     break;
                 case 5:
                     Console.Clear();
                     Console.Write("Пока-пока");
                     Environment.Exit(0);
                     break;
                }
            }
        }
    }
}