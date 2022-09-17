// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число N (количество чисел ряда Фибоначчи):");
int N = Convert.ToInt32(Console.ReadLine());



if (N > 2)
{
  int[] Fib = new int[N];
  Fib[0] = 0;
  Fib[1] = 1;
  for (int i = 2; i < Fib.Length; i++)
  {
    Fib[i] = Fib[i-2] + Fib[i-1];
  }
  Console.WriteLine(string.Join(" ", Fib));
}
else
{
  Console.WriteLine("Число N должно быть больше 2");
}
