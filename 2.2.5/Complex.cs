namespace ConsoleApp5
{

    public class Person
    {
        public int Num1 { get; set; }

        public int Num2 { get; set; }
        
        public Person()
        {
            Console.WriteLine("Введите первое число: ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            Num2 = Convert.ToInt32(Console.ReadLine());
        }

        
        ~Person()
        {
            Console.WriteLine($"{Num1} Объект удалён");
            Console.WriteLine($"{Num2} Объект удалён");
        }
    }
}