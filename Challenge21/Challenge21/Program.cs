using Challenge21;

var employee = new Employee("Łukasz", "Walczak");

employee.AddGrade("4000");
employee.AddGrade("Łukasz");
employee.AddGrade(6);
employee.AddGrade(7);
employee.AddGrade(12.0M);
employee.AddGrade(9L);

var statistics = employee.GetStatistics();


Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");