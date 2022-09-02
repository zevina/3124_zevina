// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



//Работает как для положительных, так и для отрицательных чисел

Console.WriteLine("Введите число:");
long userNumber = Convert.ToInt64(Console.ReadLine());
if (Math.Abs(userNumber) >=100)
{
    long number = Math.Abs(userNumber);
      while (number > 999)
      {
        number = number / 10;
      }
      long digit3 = number % 10; //остаток от деления на 10 трехзначного числа --> третья цифра
      Console.WriteLine($"Третья цифра числа {userNumber}: {digit3}");
}
else
{
  Console.WriteLine("Третьей цифры нет!");
}
