// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
string userNumber = Console.ReadLine();
int number = Convert.ToInt32(userNumber);

if (Math.Abs(number) <= 99999 && Math.Abs(number) > 9999)
{
  if (userNumber[0] == userNumber[4] && userNumber[1] == userNumber[3])
  {
    Console.WriteLine("Да. Число является палиндромом");
  }
  else
  {
    Console.WriteLine("Нет. Число не палиндром");
  }
}
else
{
  Console.WriteLine("Число введено некорректно!");
}