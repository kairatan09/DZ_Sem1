// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите цельное цисло:");
int number = Convert.ToInt32(Console.ReadLine());

for (int index = 2; index <= number; index += 2)
{
  Console.Write(index + " ");
}