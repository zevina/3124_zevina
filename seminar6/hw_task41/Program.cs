// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3

Console.WriteLine("Вводите числа поочередно через пробел. По окончании нажмите Enter");

string nums = Console.ReadLine();
string[] numbers = nums.Split(new char[] {' '});
int[] resultArray = new int[numbers.Length];
for (int i = 0; i < numbers.Length; i++)
{
  resultArray[i] = Convert.ToInt32(numbers[i]);
}


int CountElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) 
            count++; 
    }
    return count;
}

Console.WriteLine($"Количество чисел больше нуля: {CountElements(resultArray)}");