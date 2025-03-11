
using static ChallengeApp2.EmployeeBase;

namespace ChallengeApp2
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(int grade);
        void AddGrade(long grade);
        void AddGrade(char grade);
        event GradeAddedDelegate GradeAdded;
        Statistics GetStatistics();
    }
}
