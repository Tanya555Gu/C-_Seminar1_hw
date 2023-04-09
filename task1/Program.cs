// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7, min = 5
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("Введите число a ");
string a;
a = Console.ReadLine();
int number1 = Convert.ToInt32(a);
Console.WriteLine("Введите число b ");
string b;
b = Console.ReadLine();
int number2 = Convert.ToInt32(b);
if (number1 > number2)
{
    Console.WriteLine("max = " + number1);
    Console.WriteLine("min = " + number2);
}
else
{
    Console.WriteLine("max = " + number2);
    Console.WriteLine("min = " + number1);
}