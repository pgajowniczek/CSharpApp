using System.Linq;
namespace CSharpApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);
            }

        }

        public void AddGrade(double grade)
            {
            var value = (float)grade;
            AddGrade(value);
            }

        public void AddGrade(long grade)
        {
            var value = (float)grade;
            AddGrade(value);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
        {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
        }

            statistics.Average /= this.grades.Count;

            return statistics;
        }
    }
}
