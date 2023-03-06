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

            var statistics = employee.GetStatisticsWithForEach();

            // assert

            Assert.AreEqual(7, statistics.Max);

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

            var statistics = employee.GetStatisticsWithForEach();

            // assert

            Assert.AreEqual(5, statistics.Min);

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

            var statistics = employee.GetStatisticsWithForEach();

            // assert

            Assert.AreEqual(Math.Round(6.0, 3), Math.Round(statistics.Average, 3));
        }
    }
}
