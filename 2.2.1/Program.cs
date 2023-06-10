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
                     AddAll(stud);
                     stud.StudentInfo();
                     Console.Write("\n");
                     break;                    
                    case 2: 
                        stud.StudentInfo();
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
                             stud.SName = Console.ReadLine();
                             stud.StudentInfo();
                             break;
                         case 2:
                             Console.Write("Введите дату: ");
                             stud.Date = Console.ReadLine();
                             stud.StudentInfo();
                             break;
                         case 3:
                             Console.Write("Введите номер группы: ");
                             stud.NumGroups = Convert.ToInt32(Console.ReadLine());
                             stud.StudentInfo();
                             break;
                         case 4:
                             stud.AcademicPerformance = new int[5];
                             for (int j = 0; j < stud.AcademicPerformance.Length; j++)
                             {
                                 Console.Write("Введите успеваемость: ");
                                 stud.AcademicPerformance[j] = Convert.ToInt32(Console.ReadLine());
                             }
                             stud.StudentInfo();
                             break; }
                     break;
                }
            }
        }

       static void AddAll(Student stud)
        {
            Console.Write("Введите фамилию: ");
            stud.SName = Console.ReadLine();
            
            Console.Write("Введите дату: ");
            stud.Date = Console.ReadLine();
            
            Console.Write("Введите номер группы: ");
            stud.NumGroups = Convert.ToInt32(Console.ReadLine());
            
            stud.AcademicPerformance = new int[5];
            for (int j = 0; j < stud.AcademicPerformance.Length; j++)
            {
               Console.Write("Введите успеваемость: ");
               stud.AcademicPerformance[j] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.Write("\n");
        }
    }
}