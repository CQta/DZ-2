Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
x /=10;
Console.Write("2-я цифра числа = " + x%10);