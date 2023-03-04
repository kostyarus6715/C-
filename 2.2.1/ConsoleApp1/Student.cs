
using System.Collections.Generic;
using System.Globalization;
namespace ConsoleApp1;

public class Student
{
public string sName { get; set; } //Фамилия
public string date { get; set; } //Дата
public int numGroups { get; set; } //Номер группы
public int[] uspev { get; set; } //Успеваемость

public void studenInfo()
{
    Console.WriteLine($"Фамилия: {sName} \n" +
                        $"Дата рождения: {date} \n" +
                        $"Номер группы: {numGroups}");
    Console.Write( $"Успеваемость: ");
    foreach (var i in uspev)
    {
        Console.Write(i + " ");
    }
    Console.Write("\n");
    Console.ReadKey();
}
}