/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.*/


Console.WriteLine("Введите первое число");
string namberOnerStr = Console.ReadLine() ?? "";
int namberA = Convert.ToInt32(namberOnerStr);
Console.WriteLine("Введите второе число");
string namberTwoStr = Console.ReadLine() ?? "";
int namberB = Convert.ToInt32(namberTwoStr);
Console.WriteLine("Введите третье число");
string namberThreeStr = Console.ReadLine() ?? "";
int namberC = Convert.ToInt32(namberThreeStr);
int max= 0 ;
if (namberA > max) max = namberA;
if (namberB > max) max = namberB;
if (namberC > max) max = namberC; 
Console.WriteLine(max);
