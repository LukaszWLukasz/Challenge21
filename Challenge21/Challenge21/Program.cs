using Challange21;
using Challenge21;

Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("Witamy w Programie Do Oceny Pracowników");
Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
Console.WriteLine();


var employee = new EmployeeInFile("Łukasz", "Walczak");
employee.AddGrade(0.5f);



/*
while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika:");
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
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

*/
