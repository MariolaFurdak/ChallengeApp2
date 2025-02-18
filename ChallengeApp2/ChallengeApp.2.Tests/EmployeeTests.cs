using ChallengeApp2;

namespace ChallengeApp._2.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void LetterValueCheck()
        {
            var employee = new Employee("Mariola", "Nowak");
            //arrange
            employee.AddGrade(50);
            employee.AddGrade(40);
            employee.AddGrade(80);
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual('C', statistics.AverageLetter);
        }

        [Test]
        public void AverageLetterValueCheck()
        {
            var employee = new Employee("Mariola", "Nowak");
            //arrange
            employee.AddGrade(100);
            employee.AddGrade(100);
            employee.AddGrade(40);
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual('A', statistics.AverageLetter);
        }
        [Test]

        public void AverageValueCheck()
        {
            var employee = new Employee("Mariola", "Nowak");
            //arrange
            employee.AddGrade(1);
            employee.AddGrade(5);
            employee.AddGrade(9);
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(5, statistics.Average);
        }

    }
}
