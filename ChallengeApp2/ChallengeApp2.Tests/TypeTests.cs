using NUnit.Framework;

namespace ChallengeApp2.Tests
{
    public class TypeTests
    {
        [Test]
        public void TwoStringShouldBeEqual()
        {
            //arrange
            string number1 = "Zosia";
            string number2 = "Zosia";

            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void CheckIntShouldBeCorrectly()
        {
            //arrange
            int number1 = 20;
            int number2 = 20;
            int number3 = 40;

            //act
            var result = number3 - number2; 

            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void WhenComparedTwoFloat_ShouldBeNotEqual()
        {
            //arrange
            float number1 = 5.3f;
            float number2 = 0.5f;

            //assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void CheckEmployee_ShouldBeNotEqual()
        {
            //arrange
            var Employee1 = GetEmployee ("Daniel", "Nowak", 33);
            var Employee2 = GetEmployee("Daniel", "Kowalski", 44);

            //assert
            Assert.AreNotEqual(Employee1, Employee2);
        }
        private Employee GetEmployee(string name,string surname, int age)
        {
            return new Employee(name, surname, age);
        }

    }
}
