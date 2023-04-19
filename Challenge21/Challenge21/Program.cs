using Challenge21;

Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("Witamy w Programie Do Oceny Pracowników");
Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
Console.WriteLine();


var employee = new EmployeeInMemory("Łukasz", "Walczak");
var employee1 = new EmployeeInFile ("Łukasz", "Walczak");
employee.GradeAdded += EmployeeGradeAdded;
employee1.GradeAdded += Employee1GradeAdded;

//employee1.AddGrade(55);
//employee1.AddGrade("b");

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
        employee1.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

void Employee1GradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}


var statistics = employee1.GetStatistics();
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");


