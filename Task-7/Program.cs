// Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, 
// которая принимает на вход целое число любой разрядности 
// и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 5
// 78 -> 8
// 9146548 -> 1
// 3 -> нет

Console.WriteLine("Введите любое целое цисло:");
int number = Convert.ToInt32(Console.ReadLine());
// int index = 1;
int index = Convert.ToInt16(Math.Log10(number));

if (number < 10)

  Console.WriteLine("Нет");

else if (number < 100)

  Console.WriteLine(number % 10);

else
{
  int temp1 = Convert.ToInt32(Math.Pow(10, index - 1));
  int temp2 = number / temp1;
  int temp3 = Convert.ToInt32(Math.Pow(10, index - 2));
  int temp4 = number / temp3;
  int temp5 = temp4 - temp2 * 10;
  Console.WriteLine(temp5);
}