// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

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

int DeltaMaxMin(int[] arr)
{
  int delta = 0;
  int max = arr[0];
  int min = arr[0];
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > max)
    {
      max = arr[i];
    }
    else if (arr[i] < min)
    {
      min = arr[i];
    }
    delta = max - min;
  }
  return delta;
}


Console.WriteLine("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(number, 1, 99);
Console.WriteLine("Рандомный массив натуральных чисел: " + string.Join(", ", array));
int delta = DeltaMaxMin(array);
Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + delta);