// See https://aka.ms/new-console-template for more information
using BethanysPieShopHRM;
Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee beth = new Employee("beth", "smith", "beth@aol.com", new DateTime(1979, 1, 16), 25);

beth.DisplayEmployeeDetails();

beth.PerformWOrk(1);
beth.PerformWOrk(1);
beth.PerformWOrk(5);
beth.PerformWOrk(1);

double receivedWageBeth = beth.ReceiveWage(true);
Console.WriteLine($"Wage paid (msg from program): {receivedWageBeth}");


