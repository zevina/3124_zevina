// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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


Console.WriteLine("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(number, 0, 9);
// int[] array = {1, 2, 3, 4, 5};
Console.WriteLine("Исходный массив: " + string.Join(", ", array));



int[] arrayNew = new int[(array.Length+1)/2]; //создаем новый массив длиной: (длина старого массива + 1)/2 , чтобы забронировать память для элемента в случае если количество старого массива нечетное
for (int i = 0; i < arrayNew.Length; i++)
{
  arrayNew[i] = array[i] * array[array.Length - 1 - i]; //в новый элемент массива пишем произведение зеркальных элементов старого массива
}
if(array.Length%2 != 0) //если количество элементов нечетное...
{
    arrayNew[arrayNew.Length-1] = array[array.Length/2]; //записваем последним элементом нового массива элемент из старого массива, лежащий посередине {1,2, 3 ,4,5} --> {3}
}

Console.WriteLine("Новый массив: " + string.Join(", ", arrayNew));
