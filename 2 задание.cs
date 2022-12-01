int x;
int sum = 0;
System.Console.WriteLine("Введите число");
x = int.Parse(Console.ReadLine());
for(;x!=0;x/=10)
{
    sum += x%10;
}
System.Console.WriteLine("Сумма чисел = " + sum);