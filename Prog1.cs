System.Console.WriteLine("Введите число a");
double a = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число b");
double b = double.Parse(Console.ReadLine());
double c = 1;
for(int i = 0;i<b;i++) c *= a;
System.Console.WriteLine("a в степени b = " + c);