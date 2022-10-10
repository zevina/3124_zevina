// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Доп.условие для 51 задачи: сделать суммирование в один цикл.Матрица может быть прямоугольный

int[,] GetMatrix(int size1, int size2, int leftRange, int rightRange) // Наполнение массива случайными числами.
{
  int[,] matrix = new int[size1, size2];
  Random rand = new Random();
  for (int i = 0; i < size1; i++)
  {
    for (int j = 0; j < size2; j++)
    {
      matrix[i, j] = rand.Next(leftRange, rightRange + 1);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] matrix) // Вывод массива в терминал.
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
  }
}

int SumDiagonalMatrix(int[,] matrix) // Подсчет суммы элементов на главной диагонали.
{
  int sum = 0;
  int j = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    if (i == j)
    {
      sum += matrix[i, j];
    }
    j++;
  }
  return sum;
}


Console.WriteLine("Введите количество строк матрицы: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int[,] matr = GetMatrix(number1, number2, 0, 9);
Console.WriteLine("Рандомная матрица:");
PrintMatrix(matr);
Console.WriteLine();

int summa = SumDiagonalMatrix(matr);
Console.WriteLine($"Cумма элементов, находящихся на главной диагонали: {summa}");

// Решение преподавателя

/*int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 9)
{
  int[,] matrix = new int[rowsCount, columnsCount];

  Random rand = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rand.Next(leftRange, rightRange + 1);
    }
  }

  return matrix;
}


int ReadNumber(string message)
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}


void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
  }
}
int SumMainDiagonal(int[,] matrix)
{
  int sum = 0;
  int min;
  if (matrix.GetLength(0) >= matrix.GetLength(1))
  {
    min = matrix.GetLength(1);
  }
  else
  {
    min = matrix.GetLength(0);
  }
  for (int i = 0; i < min; i++)
  {
    sum = sum + matrix[i, i];
  }
  return sum;
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);

System.Console.WriteLine();
Console.WriteLine("Сумма элементов на диагонали:");
Console.WriteLine(SumMainDiagonal(matr));*/