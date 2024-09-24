using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть математичний вираз: ");
        string input = Console.ReadLine();

        try
        {
            // Використання DataTable для обчислення виразу
            var result = new DataTable().Compute(input, null);
            Console.WriteLine($"Відповідь програми: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Сталася помилка: {ex.Message}");
        }
    }
}
