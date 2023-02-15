

namespace Challenge21
{
    public class Employee
    {
        private List<int> score = new List<int>();
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }


        public Employee(string Name, string Surname, int Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;

        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }

        }
    }
}
