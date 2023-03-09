using Challenge21;

Console.WriteLine("Witaj w programie Oceny Pracownika");
Console.WriteLine();

var employee = new Employee("Łukasz", "Walczak");


while (true)
{
    Console.WriteLine("Dodaj ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched {e.Message}");
    }
   
        
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Avrerage: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AvrerageLetter: {statistics.AverageLetter}");