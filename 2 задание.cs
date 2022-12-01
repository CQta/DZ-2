void Fnd_summ(int a) 
{
    int sum = 0;
    for(;a != 0;a /= 10)
    {
        sum = sum + (a %10);
    }
    System.Console.WriteLine(sum);
}
System.Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
Fnd_summ(a);

