// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int SumOddElements(int[] arr)
{
  int sum = 0;
  for (int i = 1; i < arr.Length; i+=2)
  {
    sum += arr[i];
  }
  return sum;
}


Console.WriteLine("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(number, -99, 99);
Console.WriteLine("Рандомный массив чисел: " + string.Join(", ", array));
Console.WriteLine("Сумма всех элементов на нечетных позициях: " + SumOddElements(array));
