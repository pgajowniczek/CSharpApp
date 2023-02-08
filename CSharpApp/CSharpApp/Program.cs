using CSharpApp;


var employee = new Employee("Piotr", "Gajowniczek");
employee.AddGrade(1);
employee.AddGrade(2);
employee.AddGrade(9);
Console.WriteLine("Zwykłe: ");
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

Console.WriteLine();
Console.WriteLine("Foreach");
var statistics2 = employee.GetStatisticsWithForEach();
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

Console.WriteLine();
Console.WriteLine("For");
var statistics3 = employee.GetStatisticsWithFor();
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");

Console.WriteLine();
Console.WriteLine("Do While");
var statistics4 = employee.GetStatisticsWithDoWhile();
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");


Console.WriteLine();
Console.WriteLine("While");
var statistics5 = employee.GetStatisticsWithWhile();
Console.WriteLine($"Average: {statistics5.Average:N2}");
Console.WriteLine($"Min: {statistics5.Min}");
Console.WriteLine($"Max: {statistics5.Max}");

