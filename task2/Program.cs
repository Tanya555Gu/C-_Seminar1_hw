// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число ");
string a;
a = Console.ReadLine();
int number1 = Convert.ToInt32(a);
Console.WriteLine("Введите второе число ");
string b;
b = Console.ReadLine();
int number2 = Convert.ToInt32(b);
Console.WriteLine("Введите третье число ");
string c;
c = Console.ReadLine();
int number3 = Convert.ToInt32(c);
if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.WriteLine("max = " + number1);
    }
    else
    {
        Console.WriteLine("max = " + number3);
    }
}
else
{
    if (number2 > number3)
    {
        Console.WriteLine("max = " + number2);
    }
    else
    {
        Console.WriteLine("max = " + number3);
    }
}