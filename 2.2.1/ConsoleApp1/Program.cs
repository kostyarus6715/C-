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
            Student stud = new Student();
            for (int i = 0; i >= 0; i++)
            {
                Console.Write("Выберите пункт: \n" +
                              "1 - Добавить информацию \n" +
                              "2 - Просмотр \n" +
                              "3 - Изменение \n");

                              int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                 case 1:
                     addAll(stud);
                     stud.studenInfo();
                     Console.Write("\n");
                     break;                    
                    case 2: 
                        stud.studenInfo();
                     Console.Write("\n");
                     break;

                 case 3:
                     Console.WriteLine("Выберите пункт \n" +
                                   "1 - Изменить фамилию \n" +
                                   "2 - Изменить дату \n" +
                                   "3 - Изменить номер группы \n" +
                                   "4 - Изменить успеваемость ");
                     int b = Convert.ToInt32(Console.ReadLine());
                     switch (b)
                     {
                         case 1:
                             Console.Write("Введите фамилию: ");
                             stud.sName = Console.ReadLine();
                             stud.studenInfo();
                             break;
                         case 2:
                             Console.Write("Введите дату: ");
                             stud.date = Console.ReadLine();
                             stud.studenInfo();
                             break;
                         case 3:
                             Console.Write("Введите номер группы: ");
                             stud.numGroups = Convert.ToInt32(Console.ReadLine());
                             stud.studenInfo();
                             break;
                         case 4:
                             stud.uspev = new int[5];
                             for (int j = 0; j < stud.uspev.Length; j++)
                             {
                                 Console.Write("Введите успеваемость: ");
                                 stud.uspev[j] = int.Parse(Console.ReadLine());
                             }
                             stud.studenInfo();
                             break; }
                     break;
                }
            }
        }

       static void addAll(Student stud)
        {
            Console.Write("Введите фамилию: ");
            stud.sName = Console.ReadLine();
            
            Console.Write("Введите дату: ");
            stud.date = Console.ReadLine();
            
            Console.Write("Введите номер группы: ");
            stud.numGroups = Convert.ToInt32(Console.ReadLine());
            
            stud.uspev = new int[5];
            for (int j = 0; j < stud.uspev.Length; j++)
            {
               Console.Write("Введите успеваемость: ");
               stud.uspev[j] = int.Parse(Console.ReadLine());
            }
            
            Console.Write("\n");
        }
    }
}