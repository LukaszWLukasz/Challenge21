using Challenge21;

var employee1 = new Employee("Łukasz", "Walczak");

employee1.AddGrade(5);
employee1.AddGrade(6);
employee1.AddGrade(7);

var statistics = employee1.GetStatistics();


Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");