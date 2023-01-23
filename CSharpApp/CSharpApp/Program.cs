using CSharpApp;

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