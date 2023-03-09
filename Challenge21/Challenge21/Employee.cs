using System.Diagnostics;

namespace Challenge21
{
    public class Employee
    {
        private List<float> grades = new List<float>();
               
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
           }
        }

        public void AddGrade(string grade)
        {


            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                switch (grade)
                {
                    case "A" or "a":
                        this.grades.Add(100);
                        break;
                    case "B" or "b":
                        this.grades.Add(80);
                        break;
                    case "C" or "c":
                        this.grades.Add(60);
                        break;
                    case "D" or "d":
                        this.grades.Add(40);
                        break;
                    case "E" or "e":
                        this.grades.Add(20);
                        break;
                    default:
                        throw new Exception("Wrong letter");
                }
            }
        }

        public void AddGrade(long grade)
        {
            var longToFloat = (float)grade;
            this.AddGrade(longToFloat);
        }

        public void AddGrade(decimal grade)
        {
            var decimalToFloat = (float)grade;
            this.AddGrade(decimalToFloat);
        }

        public void AddGrade(int grade)
        {
            var intToFloat = (float)grade;
            this.AddGrade(intToFloat);
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
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

            statistics.Average = statistics.Average / this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    statistics.AverageLetter = 'a';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    statistics.AverageLetter = 'b';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    statistics.AverageLetter = 'c';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    statistics.AverageLetter = 'd';
                    break;
                case var average when average <= 19:
                    statistics.AverageLetter = 'E';
                    break;

            }

            return statistics;
        }
                                                          
    }
    
    
}
