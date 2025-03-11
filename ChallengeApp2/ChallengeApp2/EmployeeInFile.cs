
namespace ChallengeApp2
{
    internal class EmployeeInFile : EmployeeBase
    {
        public EmployeeInFile(string name, string surname)
          : base(name, surname)
        {
        }
        private const string fileName = "grades.txt";
        public override event GradeAddedDelegate GradeAdded;
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs()); 
                    }
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }
        
        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            if (File.Exists(fileName))
            {
                var counter = 0;

                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        result.AddGrade(number);
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
            return result;
        }
    }
}
