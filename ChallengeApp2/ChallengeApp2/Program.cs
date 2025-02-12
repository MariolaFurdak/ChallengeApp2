using ChallengeApp2;

var employee = new Employee("Daniel", "Kowalski");
employee.AddGrade("9");
employee.AddGrade("dwa");
employee.AddGrade(101);
employee.AddGrade(-5);
employee.AddGrade(5.5f);
employee.AddGrade(6);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}"); 
