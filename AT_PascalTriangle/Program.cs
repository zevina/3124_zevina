// Вывести первые N строк треугольника Паскаля.

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();

int[,] triangle = new int[n, 2*n + 1];
triangle[0, n] = 1;

for(int i = 0; i < 1; i++) //0-я строка (только 1 в центре)
{
  for (int j = 0; j < triangle.GetLength(1); j++)
  {
    if (triangle[i, j] == 0) Console.Write("  ");
    else Console.Write($"{triangle[i, j]}");
  }
}
Console.WriteLine();

for (int i = 1; i < triangle.GetLength(0); i++) //остальные строки начиная с 1-й
{
  for (int j = 1; j < triangle.GetLength(1)-1; j++)
  {
    triangle[i,j] = triangle[i-1,j-1] + triangle[i-1,j+1];
    if (triangle[i, j] == 0) Console.Write("  ");
    else Console.Write($" {triangle[i, j]} ");
  }
  Console.WriteLine();
}