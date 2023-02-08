using CSharpApp;


var employee = new Employee("Piotr", "Gajowniczek");
employee.AddGrade(1);
employee.AddGrade(2);
employee.AddGrade(9);

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");


