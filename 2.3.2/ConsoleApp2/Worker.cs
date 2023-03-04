using System;

namespace ConsoleApp1
{
    public class Worker
    {
        private string name { get; set; }
        private string surname { get; set; }
        private int rate { get; set; }
        private int days { get; set; }
        public static void GetSalary()
        {
            Worker worker = new Worker(); 
            Console.Write("Введите имя: ");
            worker.name = Console.ReadLine();
            Console.Write("Введите Фамилию: ");
            worker.surname = Console.ReadLine();
            Console.Write("Введите ставку: ");
            worker.rate = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите отработаные дни: ");
            worker.days = Convert.ToInt32(Console.ReadLine());            
            int salary = worker.rate * worker.days;
            Console.Write($"Зарплата сотрудника: {salary}");
        }
        public static void Main()
        {
            GetSalary();
        }        
    }
}