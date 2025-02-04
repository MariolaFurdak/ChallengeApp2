using ChallengeApp2;
namespace ChallengeApp._2.Tests
{
    public class Tests1
    {
        [Test]
        public void CheckIfScoreAddCurentyl()
        {
            //arrange
            var employee = new Employee("Zofia", "Kowalska", 33);
            employee.AddScore(5);
            employee.AddScore(4);
            employee.AddScore(-3);
            employee.AddScore(5);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(11, result);
        }
    }
    public class Tests2
    {
        [Test]
        public void CheckIfScoreGiveNegativeValuel()
        {
            //arrange
            var employee = new Employee("Daniel", "Nowak", 20);
            employee.AddScore(-5);
            employee.AddScore(-10);
            employee.AddScore(-3);
            employee.AddScore(5);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(-13, result);
        }
    }
}