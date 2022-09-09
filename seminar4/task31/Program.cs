// Отсортировать принимаемый массив по возрастанию

Console.WriteLine("Введите длину массива:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите поочередно элементы массива:");
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
  array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введенный массив:");
Console.WriteLine(string.Join(" ", array));
Console.WriteLine();


void SelectionSortMin (int[] array)
{
  for (int i = 0; i < array.Length-1; i++)
  {
    int minPosition = i;
    for (int j = i+1; j < array.Length; j++)
    {
      if (array[j] < array[minPosition])
      {
        minPosition = j;
      }
    }
    int temp = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temp;
  }
}

void SelectionSortMax (int[] array)
{
  for (int i = 0; i < array.Length-1; i++)
  {
    int maxPosition = i;
    for (int j = i+1; j < array.Length; j++)
    {
      if (array[j] > array[maxPosition])
      {
        maxPosition = j;
      }
    }
    int temp = array[i];
    array[i] = array[maxPosition];
    array[maxPosition] = temp;
  }
}

SelectionSortMin(array);
Console.WriteLine("Отсортированный массив (min --> max):");
Console.WriteLine(string.Join(" ", array));

Console.WriteLine();
SelectionSortMax(array);
Console.WriteLine("Отсортированный массив (max --> min):");
Console.WriteLine(string.Join(" ", array));