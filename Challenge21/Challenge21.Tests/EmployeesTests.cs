

namespace Challenge21.Tests
{
    public class Tests
    {
        [Test]
        public void WhenAddScoreEmployees_ShouldReturnSum()
        {
            // arrange
            
            var employee1  = new Employee("Kasia", "Nowak", 30);

            employee1.AddScore(5);
            employee1.AddScore(3);
            employee1.AddScore(2);

            // act

            var result = employee1.Result;

            // assert

            Assert.AreEqual(10, result);

        }
        [Test]
        public void WhenDeductScoreEmployees_ShouldReturnSum()
        {
            // arrange
            var employee2 = new Employee("Basia", "Kowalska", 40);
            employee2.AddScore(3);
            employee2.AddScore(5);
            employee2.AddScore(-10);

            //act
            var result = employee2.Result;

            // assert

            Assert.AreEqual(-2, result);
        }

    }
}