// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12 -> 2 
// 85 -> 8

Random rand = new Random();
int number = rand.Next(10,100); // [10,100)

Console.WriteLine($"Сгенерировалось случайное число {number}");
int digit2 = number % 10; //остаток от деления на 10
int digit1 = number / 10; //целая цасть от деления на 10

Console.WriteLine(digit1);
Console.WriteLine(digit2);

if (digit1 > digit2)
{
  Console.WriteLine($"Первая цифра {digit1} больше второй {digit2}");
}
else if (digit2 > digit1)
{
  Console.WriteLine($"Вторая цифра {digit2} больше первой {digit1}");
}
else
{
  Console.WriteLine("Цифры равны");
}

