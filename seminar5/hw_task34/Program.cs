// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

int CountElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] %2 == 0) //если элемент четный...
        {
            count++; //считаем количество подходящих элементов
        }
    }
    return count;
}

Console.WriteLine("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(number, 100, 999);
Console.WriteLine("Рандомный массив трехзначных чисел: " + string.Join(", ", array));
int count = CountElements(array);
Console.WriteLine("Количество четных элементов массива: " + count);