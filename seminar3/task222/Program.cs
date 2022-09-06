// Доп. задание
// Написать метод для разворота массива, не используя память под дополнительный массив

int[] array = new int[] {1, 2, 3, 4, 5};
int n = array.Length;
for (int i = 0; i < n/2; i++)
{
  int t = array[i];
  array[i] = array[n-1-i];
  array[n-1-i] = t;
}
foreach (int el in array)
{
  Console.Write(el);
}
