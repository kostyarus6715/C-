namespace ConsoleApp2;

public class Train
{
public string? Destination { get; set; } //Пункт назначения
public string? Number { get; set; } //Номер поезда
public string? Time { get; set; } //Время отправления

public void TrainInfo()
{
    Console.WriteLine($"Пункт назначения: {Destination} \n" +
                      $"Номер поезда: {Number} \n" +
                      $"Время отправления: {Time}\n" +
                      "Нажмите Enter, чтобы продолжить");
    Console.ReadKey();
    Console.Clear();
}
public void AddAlL()
{
    Console.Write("Введите пункт назначения: ");
    Destination = Console.ReadLine();

    Console.Write("Введите номер поезда: ");
    Number = Console.ReadLine();

    Console.Write("Введите время отправления: ");
    Time = Console.ReadLine();
    Console.Clear();
    Console.Write("\n");
}
public void TrainNumber(Train trains)
       {
           Console.Write("Введите номер нужного вам поезда : ");
           string? number = Console.ReadLine();
           Console.Clear();
           for (int j = 0; j < 1; j++)
           {
               if (number == Number)
               {
                   Console.Write("\nИнформация о вашем поезде\n");
                   trains.TrainInfo();
               }
               else
               {
                   Console.Write("Такого поезда нету");
                   Console.ReadKey();
               }
           }
       }
}