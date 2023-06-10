using System;
namespace ConsoleApp1
{
    public class Calculation
    {
        static string CalculationLine = "a";

        public static void SetCalculationLine()//будет изменять значение свойства
        {
            Console.Write("Введите значение свойства: ");
            CalculationLine = Console.ReadLine();
        }

        public static void SetLastSymbolCalculationLine()//который будет в конец строки прибавлять символ
        {
            Console.Write("Введите символ который будет добавлен в конец: ");
            string x = Console.ReadLine();
            Console.WriteLine($"Результат: {CalculationLine += x}");
        }

        public static void GetCalculationLine()// будет выводить значение свойства
        {
            Console.Write(CalculationLine);
        }

        public static void GetLastSymbol()//получение последнего символа
        {
            Console.Write($"Последний символ из {CalculationLine }\n");
            String b = CalculationLine.Substring(CalculationLine.Length - 1);
            Console.Write(b);
        }

        public static void DeleteLastSymbol()//удаление последнего символа из строки
        {
            CalculationLine = CalculationLine.Remove(CalculationLine.Length - 1);
            Console.Write($"Значение после удаления последнего символа {CalculationLine}");
        }

        public static void Main(string[] args)
        {
            for (int i = 0; i >= 0; i++)
            {
                Console.Clear();
                Console.Write("\nВыберите пункт:\n" +
                              "1 - Изменить значение свойства\n" +
                              "2 - Добавить в конец строки символ \n" +
                              "3 - Вывести значения свойства\n" +
                              "4 - Получить последний символ\n" +
                              "5 - Удалить последний символ\n" +
                              "6 - Выход\n");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.Clear();
                    SetCalculationLine();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        SetLastSymbolCalculationLine();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write($"Текущие значения: ");
                        GetCalculationLine();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        GetLastSymbol();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        DeleteLastSymbol();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.Write("Пока-пока");
                        Environment.Exit(0);
                        break;                    
                }
            }

        }
    }
} 