using System.Linq;
namespace CSharpApp
{
    internal class Employee
    {
        static int highestScore = 0;
        static Employee highestScoreEmployee;
        public Employee(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public int Age { get; private set; }

        private List<int> score = new List<int>();

        public void AddScore(int value)
        {
            score.Add(value);
            if (score.Sum() > highestScore)
            {
                highestScore = score.Sum();
                highestScoreEmployee = this;
            }
        }
        public static void ShowHighestScoreUser()
        {
            Console.WriteLine($"Użytkownik z najwyższą liczbą punktów: \n\nImię: {highestScoreEmployee.Name}\nNazwisko: {highestScoreEmployee.Surname}\nLiczba punktów: {highestScore}");
        }

    }
}
