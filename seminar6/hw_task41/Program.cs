// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3

Console.WriteLine("Вводите числа поочередно. По окончании введите stop");

int i = 0;
bool a = true;
while (a == true)
{
  string n = Console.ReadLine();
  if (n != "stop" && Convert.ToInt32(n) > 0) i++;
  else if (n == "stop") 
  {
    a = false;
    break;
  }
}

Console.WriteLine($"Количество чисел больше нуля: {i}");