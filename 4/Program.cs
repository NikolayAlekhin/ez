/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
*/




Console.WriteLine("Введите число");
string namberStr = Console.ReadLine() ?? "";
int nambera = Convert.ToInt32(namberStr);
if (nambera % 2 == 0 )
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечётное");
}    