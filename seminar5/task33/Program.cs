// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Массивы к задачам 32 и 33 можно сделать рандомными. В задаче 33 на экран выводится ТОЛЬКО одно сообщение: либо "да", либо "нет".

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

string SearchElements(int[] arr, int number)
{
  string result = "Нет";
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] == number)
    {
      result = "Да";
    }
  }
  return result;
}

int[] array = GetArray(5, -9, 9);
Console.WriteLine("Рандомный массив: " + string.Join(", ", array));
Console.WriteLine("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SearchElements(array, number));