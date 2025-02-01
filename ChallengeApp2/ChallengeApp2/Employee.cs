using ChallengeApp2;

Employee employee1 = new Employee("Zofia", "Kowalska", 33);
Employee employee2 = new Employee("Wiktoria", "Nowak", 55);
Employee employee3 = new Employee("Zuza", "Stach", 22);

employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(7);
employee1.AddScore(2);
employee1.AddScore(5);
//21
employee2.AddScore(6);
employee2.AddScore(6);
employee2.AddScore(1);
employee2.AddScore(5);
employee2.AddScore(3);
//21
employee3.AddScore(7);
employee3.AddScore(8);
employee3.AddScore(5);
employee3.AddScore(1);
employee3.AddScore(2);
//23
List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}


Console.WriteLine("Najwyzszą liczbe punktów:");
Console.WriteLine( employeeWithMaxResult.Result );
Console.WriteLine("Otrzymała:");
Console.WriteLine ($"{employeeWithMaxResult.Name} {employeeWithMaxResult.Surname},lat {employeeWithMaxResult.Age}");

