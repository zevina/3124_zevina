// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


int ReadNumber(string message) //Метод для ввода числа из консоли
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}


int SumNumbersFrom1ToA(int A) //Метод для суммирования чисел от 1 до А
{
    if (A >= 1)
  {
    int sum = 0;
    for (int i = 0; i <= A; i++)
    {
      sum += i;  //sum = sum + i
    }
    return sum;
  }
  else
  {
    Console.WriteLine("Число должно быть не меньше 1");
    return -1; //вернется в случае ошибки
  }
}

int number = ReadNumber("Введите число: ");
int summa = SumNumbersFrom1ToA(number);
Console.WriteLine($"Сумма чисел от 1 до А: {summa}");