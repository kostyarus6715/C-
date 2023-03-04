using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 10; //стандартное значение
            int y = x;
            for (int i = 0; i >= 0; i++)
            {
                Console.Write("Выберите пункт: \n" +
                              "1 - Увеличить значение на 1 \n" +
                              "2 - Уменьшить значение на 1 \n" +
                              "3 - Задать счётчику своё значение \n" +
                              "4 - Вернуть значение по умолчанию\n" +
                              "5 - Посмотреть текущее значение\n" +
                              "6 - Выход \n");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        plusone();
                        break;
                    case 2:
                        minusone();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Введите своё значение: ");
                        y = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write($"Значение установлено по умолчанию = {x}\n");
                        y = x;
                        break;
                    case 5:
                        Console.Clear();
                        Console.Write($"Текущее значение счётчика = {y} \n");
                        break;
                    case 6:
                        Console.Clear();
                        Console.Write("Пока-пока");
                        Environment.Exit(0);
                        break;
                }
                void plusone()
                {
                    Console.Clear();
                    Console.Write($"Результат = {y+=1}\n");
                }

                void minusone()
                {
                    Console.Clear();
                    Console.Write($"Результат = {y-=1}\n");
                }
            }
        }
    }
}

