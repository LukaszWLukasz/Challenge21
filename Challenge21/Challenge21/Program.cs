using Challenge21;

Console.WriteLine("Witaj w programie Oceny Pracowników");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine("Dodaj ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Avrerage: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AvrerageLetter: {statistics.AverageLetter}");