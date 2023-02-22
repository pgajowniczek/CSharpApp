using CSharpApp;


var employee = new Employee("Piotr", "Gajowniczek");
employee.AddGrade(80);
employee.AddGrade(56);
employee.AddGrade(99);
employee.AddGrade('a');

//try
//{
//    employee.AddGrade(120);
//}
//catch (Exception e)
//{
//    Console.WriteLine($"Exception catched: {e.Message}");
//}

//var statistics = employee.GetStatistics();
//Console.WriteLine($"Average: {statistics.Average:N2}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");
//Console.WriteLine($"Average Letter: {statistics.AverageLetter}");

var testPerson = new EmployeeInFile("Piotr", "Gajowniczek");
testPerson.AddGrade(0.5f);

