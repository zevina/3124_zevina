﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= number)
{  
  int kvadrant = Convert.ToInt32(Math.Pow(count,3));
  Console.Write(kvadrant + " ");
  count++;
}
if (number <= 0)
{
  Console.WriteLine("число должно быть положительное");
}