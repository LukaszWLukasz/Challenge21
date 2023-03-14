namespace Challenge21
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname, int age, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public char Sex { get; private set; }

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
                    case "6.0":
                        this.grades.Add(100);
                        break;
                    case "6-":
                        this.grades.Add(95);
                        break;
                    case "5+":
                        this.grades.Add(90);
                        break;
                    case "5.0":
                        this.grades.Add(85);
                        break;
                    case "5-":
                        this.grades.Add(80);
                        break;
                    case "4+":
                        this.grades.Add(75);
                        break;
                    case "4.0":
                        this.grades.Add(70);
                        break;
                    case "4-":
                        this.grades.Add(65);
                        break;
                    case "3+":
                        this.grades.Add(60);
                        break;
                    case "3.0":
                        this.grades.Add(55);
                        break;
                    case "3-":
                        this.grades.Add(50);
                        break;
                    case "2+":
                        this.grades.Add(45);
                        break;
                    case "2.0":
                        this.grades.Add(40);
                        break;
                    case "2-":
                        this.grades.Add(35);
                        break;
                    case "1+":
                        this.grades.Add(30);
                        break;
                    case "1.0":
                        this.grades.Add(20);
                        break;
                    case "1-":
                        this.grades.Add(10);
                        break;
                    case "0":
                        this.grades.Add(0);
                        break;

                    default:
                        throw new Exception("Wrong number");
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
            var charToFloat = (char)grade;
            this.AddGrade(charToFloat);
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



