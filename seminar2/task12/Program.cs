// Задача 12: Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());


if (number2 != 0)
  {
    if (number1 % number2 == 0)
  {
    Console.WriteLine($"Число {number1} кратно числу {number2}. Ура!");
  }
  else
  {
    int ost = number1 % number2; //остаток от деления чисел 34/5 = 6 (остаток 4)
    Console.WriteLine($"Первое число {number1} не кратно второму числу {number2}. Остаток от деления чисел: " + ost);
  }}
else
{
  System.Console.WriteLine("Нельзя делить на 0!!!");
}
