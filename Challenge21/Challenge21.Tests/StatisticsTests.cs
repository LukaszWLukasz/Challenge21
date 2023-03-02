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

            Assert.AreEqual(7F, statistics.Max);

        }

        [Test]

        public void EmployeeCheckPointsMin()
        {
            // arrange
            var employee = new Employee("Łukasz", "Walczak");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(7);

            // act

            var statistics = employee.GetStatistics();

            // assert

            Assert.AreEqual(5F, statistics.Min);

        }

        [Test]

        public void EmployeeCheckPointsAverage()
        {
            // arrange
            var employee = new Employee("Łukasz", "Walczak");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(7);

            // act

            var statistics = employee.GetStatistics();

            // assert

            Assert.AreEqual(6.0F, statistics.Average);
        }
    }
}
