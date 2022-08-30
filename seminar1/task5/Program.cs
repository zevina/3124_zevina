// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите положительное число:");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = -numberA;
while (numberB <= numberA)
{
  Console.Write(numberB + ", ");
  numberB ++;
}
if (numberA < 0)
{
  Console.WriteLine("число должно быть положительное");
}