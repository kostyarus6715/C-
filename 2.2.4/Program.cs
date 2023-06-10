namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            string? ing = "go";
            Counter name;
            Console.WriteLine("Выберите начало отсчёта:\n1 - По умолчанию\n2 - Произвольное");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {

                name = new Counter();

            }
            else
            {
                Console.WriteLine("Введите начало отсчёта");
                input = Convert.ToInt32(Console.ReadLine());
                name = new Counter(input);
            }

            Console.WriteLine("Нажмите клавишу \"Enter\" для прибавления к числу еденицы\n" +
                    "Введите \"1\" чтобы отнять отнять еденицу\n" +
                    "Введите\"2\" чтобы узнать текущее состояние счетчика\n" +
                    "Введите\"3\" чтобы выйти из счетчика");

            while (ing != "exit")
            {
                ing = Console.ReadLine();
                if (ing == "3") break;

                switch (ing)
                {
                    case "":
                        name.Plus();
                        break;
                    case "1":
                        name.Minus();
                        break;
                    case "2":
                        int res = name.GetCount;
                        Console.WriteLine("Текущее состояние счётчика: " + res);
                        break;
                }

            }
        }
    }
}




