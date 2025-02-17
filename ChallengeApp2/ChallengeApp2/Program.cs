using ChallengeApp2;

var employee = new Employee("Daniel", "Kowalski");
employee.AddGrade(5);
employee.AddGrade(2);
employee.AddGrade(10);

var statistics1 = employee.GetStatisticsWithFor();
Console.WriteLine("Statystyki z wykozystaniem pętli For");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");

var statistics2 = employee.GetStatisticsWithForeach();
Console.WriteLine("Statystyki z wykozystaniem pętli Foreach");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

var statistics3 = employee.GetStatisticsWithWhile();
Console.WriteLine("Statystyki z wykozystaniem pętli While");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");

var statistics4 = employee.GetStatisticsWithDoWhile();
Console.WriteLine("Statystyki z wykozystaniem pętli DoWhile");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");