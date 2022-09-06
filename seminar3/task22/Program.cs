// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= number)
{  
  int kvadrant = Convert.ToInt32(Math.Pow(count,2));
  Console.Write(kvadrant + " ");
  count++;
}
if (number <= 0)
{
  Console.WriteLine("число должно быть положительное");
}