﻿void pow(double a, double b) 
{
    double p = 0;
    p = Math.Pow(a, b);
    System.Console.WriteLine("a в степени b = ", p);
}
System.Console.WriteLine("Введите кеш");
double a = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите годовой процент");
double b = double.Parse(Console.ReadLine());
pow(a, b);

