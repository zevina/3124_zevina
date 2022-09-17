// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

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

Console.WriteLine("Введите количество элементов массива:");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = GetArray(size, 0, 10);
Console.WriteLine($"Исходный массив: {string.Join(", ", arr)}");

int[] arrayCopy = new int[size];
for (int i = 0; i < arrayCopy.Length; i++)
{
  arrayCopy[i] = arr[i];
}
Console.WriteLine($"Скопированный массив: {string.Join(", ", arrayCopy)}");