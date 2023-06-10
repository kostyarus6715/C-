namespace ConsoleApp3
{
    public class Numbers
    {
        public int Chislo1 { get; set; } //Число 1
        
        public int Chislo2 { get; set; } //Число 2

        public void AddAll()
        {
            Console.Write("Введите первое число: ");
            Chislo1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите второе число: ");
            Chislo2 = Convert.ToInt32(Console.ReadLine());
        }

        public void NumberInfo()
        {
            Console.Write($"Первое число: {Chislo1}"+
                          $"\nВторое число: {Chislo2}"+
                          $"\n Нажмите Enter, чтобы продолжить");
            Console.ReadKey();
        }

        public void Sum()
        {
            int a = Chislo1 + Chislo2;
            Console.Write($"Сумма чисел {Chislo1} + {Chislo2} = {a}\n"+
                          "Нажмите Enter, чтобы продолжить");
            Console.ReadKey();
        }

        public void Comparison()
        {
            Console.Write($"Из введёных чисел {Chislo1} и {Chislo2}");
            if (Chislo1 > Chislo2)
            {
                Console.Write($"\n{Chislo1} является наибольшим");
            }
            else if (Chislo2 > Chislo1)
            {
                Console.Write($"\n{Chislo2} является наибольшим");
            }
            else
            {
                Console.Write($"\nВведёные числа равны");
            }
            Console.ReadKey();
        }
    }
    
}