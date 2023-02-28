namespace Challenge21.Tests
{
    public class TypeTests
    {
        [Test]
        public void EmpolyeeDifrentTypeReference()
        {
            // arrange
            var Employee1 = GetUser("Łukasz", "Kowalski", 30);
            var Employee2 = GetUser("Karol", "Kowalski", 30);
                        
            // act

            // assert

            Assert.AreNotEqual(Employee1, Employee2);


        }

        private Employee GetUser(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }

        [Test]
        public void NumbersIntDifrentTypeValue()
        {
            // arrange
            int number1 = 15;
            int number2 = 20;
            int number3 = 6;
            int number4 = 6;

            // act

            // assert

            Assert.AreNotEqual(number1, number2);
            Assert.AreEqual(number3, number4);

        }
        [Test]
        public void NumbersFloatEqualTypeValue()
        {
            // arrange
            float number1 = 7.8F;
            float number2 = 7.8F;
                                    
            // act

            // assert

            Assert.AreEqual(number1, number2);
           

        }
    }

}
