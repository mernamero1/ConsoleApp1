// See https://aka.ms/new-console-template for more information

// task 1
Console.Write("Number of small Carpets ");
int  n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Number of large Carpets ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("price per small Carpets : 25$");
Console.WriteLine("price per large Carpets : 35$");

float cost = (n1 * 25 + n2 * 35);
Console.WriteLine($"{cost}$");


float Total_estimate = cost * (6f / 100f) + cost;
Console.WriteLine($"{Total_estimate}$");

Console.WriteLine("This estimate is valid for 30 days"); 

int x = 10;
int y = 20;
Console.WriteLine($"Equation : {x} + {y} = {x + y:P}");
