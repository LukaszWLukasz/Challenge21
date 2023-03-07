namespace Challenge21.Tests
{
    public class StatisticsTests
    {

        [Test]

        public void EmployeeCheckPointsMax()
        {
            // arrange
            var employee = new Employee("Łukasz", "Walczak");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(7);

            // act

            var statistics = employee.GetStatistics();

            // assert

            Assert.AreEqual(7, statistics.Max);

        }

        [Test]

        public void EmployeeCheckPointsMin()
        {
            // arrange
            var employee = new Employee("Łukasz", "Walczak");
            employee.AddGrade(5);
            employee.AddGrade("a");
            employee.AddGrade(7);

            // act

            var statistics = employee.GetStatistics();

            // assert

            Assert.AreEqual(statistics.Min, 5);

        }

        [Test]

        public void EmployeeCheckPointsAverage()
        {
            // arrange
            var employee = new Employee("Łukasz", "Walczak");
            employee.AddGrade(5);
            employee.AddGrade("c");
            employee.AddGrade(7);

            // act

            var statistics = employee.GetStatistics();

            // assert

            Assert.AreEqual(Math.Round(24.0, 3), Math.Round(statistics.Average, 3));
        }

        [Test]

        public void EmployeeCheckPointsLetterChar()
        {
            // arrange
            var employee = new Employee("Łukasz", "Walczak");
            employee.AddGrade('A');
            employee.AddGrade('b');
            employee.AddGrade('C');

            // act

            var statistics = employee.GetStatistics();

            // assert

            Assert.AreEqual(statistics.AverageLetter, 'a');
        }

        [Test]

        public void EmployeeCheckPointsLetterString()
        {
            // arrange
            var employee = new Employee("Łukasz", "Walczak");
            employee.AddGrade("c");
            employee.AddGrade("C");
            employee.AddGrade("a");

            // act

            var statistics = employee.GetStatistics();

            // assert

            Assert.AreEqual(statistics.AverageLetter, 'b');
        }
    }
}
