/* Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Введите число:");
string numberA = Console.ReadLine();
Console.WriteLine("Введите число:");
string numberB = Console.ReadLine();

int A = int.Parse(numberA);
int B = int.Parse(numberB);

if (A > B)

        Console.WriteLine($"Число {A} max, число {B} min");

    else

        Console.WriteLine($"Число {B} max, число {A} min");
