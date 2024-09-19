// See https://aka.ms/new-console-template for more information
using ClassColaboration;

Console.WriteLine("Hello, World!");
Car c1 = new Car("Citroen", 5000);
c1.Start();
double totalEmission = c1.CalCo2Emission();
Console.WriteLine($"totalemission {totalEmission}");
Console.WriteLine(c1.ToString());