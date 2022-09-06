// Доп. задание
// Написать метод для разворота массива, не используя память под дополнительный массив

// int[] array = new int[] {1, 2, 3, 4, 5};
int[] array = new int[7];
Random rand = new Random();
int n = array.Length;

for (int i = 0; i < n; i++)
  array[i] = rand.Next(0, 10);
foreach (int el in array)
{
  Console.Write(el);
}
Console.WriteLine(" ");


for (int j = 0; j < n/2; j++)
{
  int t = array[j];
  array[j] = array[n-1-j];
  array[n-1-j] = t;
}
foreach (int el in array)
{
  Console.Write(el);
}
