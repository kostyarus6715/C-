using System;

namespace ConsoleApp1
{
    public class Program
    {
        public int Num1 { get; set; }

        public int Num2 { get; set; }


        public Program(int Num1, int Num2)
        {
            this.Num1 = Num1;
            this.Num2 = Num2;
        }

        public Program()
        {
            Num1 = 222;
            Num2 = 333;
        }

        ~Program()
        {
            Console.WriteLine($"{Num1} объект удалён");
            Console.WriteLine($"{Num2} объект удалён");
        }

        static void Method()
        {
            Program ad = new Program();
        }

        static void Main(string[] args)
        {
            Method();
            GC.Collect();
        }
    }
}