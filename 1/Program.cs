/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Введите первое число");
string namberOnerStr = Console.ReadLine();
int nambera = Convert.ToInt32(namberOnerStr);
Console.WriteLine("Введите второе число");
string namberTwoStr = Console.ReadLine();
int namberb = Convert.ToInt32(namberTwoStr);
if (nambera > namberb)
{
Console.WriteLine(namberOnerStr);
}
if (nambera<namberb)
{
Console.WriteLine(namberTwoStr);
}
else
{
Console.WriteLine("equals");
}