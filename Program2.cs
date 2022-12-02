Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
string s;
if(x>99)
{
    s = x.ToString();
    Console.Write("3-я цифра числа = " + s[2]);
}
else
{
    Console.Write("3 цифры нет");
}
