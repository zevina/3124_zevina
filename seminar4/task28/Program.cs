// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int ReadNumber(string message) //Метод для ввода числа из консоли
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}


int MultiNumbersFrom1ToA(int A) //Метод для умножения чисел от 1 до А
{
    if (A >= 1)
  {
    int mtp = 1;
    for (int i = 1; i <= A; i++)
    {
      mtp = mtp * i;
    }
    return mtp;
  }
  else
  {
    Console.WriteLine("Число должно быть не 0!");
    return -1; //вернется в случае ошибки
  }
}


int number = ReadNumber("Введите число: ");
int multi = MultiNumbersFrom1ToA(number);
Console.WriteLine($"Произведение чисел от 1 до А: {multi}");