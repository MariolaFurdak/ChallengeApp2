﻿using ChallengeApp2;

Console.WriteLine("Witam w progranie do oceny pracownikow");
Console.WriteLine();

var employee = new Employee("Daniel", "Kowalski", 'M');
while (true)
{
  Console.WriteLine("Podaj kolejną ocene pracownika");
  var input = Console.ReadLine();
  if (input == "q")
    {
        break;
    }

  try
    {
       employee.AddGrade(input);
    }
    catch (Exception e) 
    {
        Console.WriteLine($"Exception catched:{e.Message}");
    }
    
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");