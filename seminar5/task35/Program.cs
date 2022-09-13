// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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
        if(arr[i] >= 10 && arr[i] <=99) //если элемент лежит в диапазоне [10,99]
        {
            count++; //считаем количество подходящих элементов
        }
    }
    return count;
}

int[] array = GetArray(123, 0, 150);
Console.WriteLine("Рандомный массив 123-х чисел в диапазоне [0, 150]: " + string.Join(", ", array));
int count = CountElements(array);
Console.WriteLine("Количество элементов массива, которых лежат в отрезке [10,99]: " + count);