using CSharpApp;


var employee = new Employee("Piotr", "Gajowniczek");
employee.AddGrade(80);
employee.AddGrade(56);
employee.AddGrade(99);
employee.AddGrade('a');

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");


