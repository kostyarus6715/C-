namespace ConsoleApp3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            for (int i = 0; i >= 0; i++)
            {
                Console.Clear();
                Console.Write("Выберите пункт: \n" +
                              "1 - Добавить числа \n" +
                              "2 - Посмотреть введёные числа \n" +
                              "3 - Изменение чисел \n" +
                              "4 - Найти сумму этих чисел \n" +
                              "5 - Найти наибольше из чисел \n" +
                              "6 - Выход \n");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.Clear();
                        numbers.AddAll();
                        break;
                    case 2:
                        Console.Clear();
                        numbers.NumberInfo();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Выберите пункт \n"+
                                          "1 - Изменить первое число\n"+
                                          "2 - Изменить второе число\n"+
                                          "3 - Изменить оба числа\n");
                        int b = Convert.ToInt32(Console.ReadLine());
                        switch (b)
                        {
                            case 1:
                                Console.Clear();
                                Console.Write("Введите первое число: ");
                                numbers.Chislo1 = Convert.ToInt32(Console.ReadLine());
                                numbers.NumberInfo();
                                break;
                            case 2:
                                Console.Clear();
                                Console.Write("Введите второе число: ");
                                numbers.Chislo2 = Convert.ToInt32(Console.ReadLine());
                                numbers.NumberInfo();
                                break;
                            case 3:
                                Console.Clear();
                                numbers.AddAll();
                                break;
                        }
                        break;
                        case 4:
                            Console.Clear();
                            numbers.Sum();
                            break;
                        case 5:
                            Console.Clear();
                            numbers.Comparison();
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