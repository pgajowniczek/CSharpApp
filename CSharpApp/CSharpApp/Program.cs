using CSharpApp;

<<<<<<< HEAD
var employee = new Employee("Piotr", "Gajowniczek");
employee.AddGrade(2);
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
=======
Employee user1 = new Employee("Marek", "Adamiak", 23);
Employee user2 = new Employee("Irena", "Nowak", 25);
Employee user3 = new Employee("Jan", "Kowalski", 35);

user1.AddScore(2);
user1.AddScore(6);
user1.AddScore(4);
user1.AddScore(5);
user1.AddScore(7);
//24

user2.AddScore(1);
user2.AddScore(3);
user2.AddScore(2);
user2.AddScore(2);
user2.AddScore(5);
//13

user3.AddScore(10);
user3.AddScore(9);
user3.AddScore(8);
user3.AddScore(8);
user3.AddScore(10);
//45

Employee.ShowHighestScoreUser();
>>>>>>> 73fdceabc66c461c60daec2e30d32dd607929bdf
