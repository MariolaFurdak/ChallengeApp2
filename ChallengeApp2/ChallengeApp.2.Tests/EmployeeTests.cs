using ChallengeApp2;

namespace ChallengeApp._2.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void MaxValueCheck()
        {
            var employee = new Employee("Mariola", "Nowak");
            //arrange
            employee.AddGrade(5);
            employee.AddGrade(9);
            employee.AddGrade(4);
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(9, statistics.Max);
        }

        [Test]
        public void MinValueCheck()
        {
            var employee = new Employee("Mariola", "Nowak");
            //arrange
            employee.AddGrade(5.6f);
            employee.AddGrade(9);
            employee.AddGrade(4);
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(4, statistics.Min);
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
