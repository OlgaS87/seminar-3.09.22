/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */


Console.WriteLine("Введите число:");
string numberA = Console.ReadLine();
Console.WriteLine("Введите число:");
string numberB = Console.ReadLine();
Console.WriteLine("Введите число:");
string numberC = Console.ReadLine();

int A = int.Parse(numberA);
int B = int.Parse(numberB);
int C = int.Parse(numberC);

int max = A;

if (A > max) max = A;
if (B > max) max = B;
if (C > max) max = C;

Console.WriteLine(max);
      