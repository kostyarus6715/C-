namespace ConsoleApp1;

public class Student
{
public string? SName { get; set; } //Фамилия
public string? Date { get; set; } //Дата
public int NumGroups { get; set; } //Номер группы
public int[] AcademicPerformance { get; set; } //Успеваемость

public void StudentInfo()
{
    Console.WriteLine($"Фамилия: {SName} \n" +
                        $"Дата рождения: {Date} \n" +
                        $"Номер группы: {NumGroups}");
    Console.Write( $"Успеваемость: ");
    foreach (var i in AcademicPerformance)
    {
        Console.Write(i + " ");
    }
    Console.Write("\n");
    Console.ReadKey();
}
}