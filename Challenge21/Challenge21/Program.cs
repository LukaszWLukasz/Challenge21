using Challenge21;

var employee = new Employee("Łukasz", "Walczak");

employee.AddGrade("4000");
employee.AddGrade("Łukasz");
employee.AddGrade(6);
employee.AddGrade(7);
employee.AddGrade(12.0M);
employee.AddGrade(9L);

Console.WriteLine();

var statistics1 = employee.GetStatisticsWithForEach();

Console.WriteLine("For Each");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine();


var statistics2 = employee.GetStatisticsWithFor();

Console.WriteLine("For");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine();


var statistics3 = employee.GetStatisticsWithDoWhile();

Console.WriteLine("Do While");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine();

var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine("While");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");