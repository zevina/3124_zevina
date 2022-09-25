﻿// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7


int ReadNumber(string message) // Ввод числа из консоли.
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rows, int columns, int leftRange = -10, int rightRange = 10) // Наполнение массива случайными числами.
{
  int[,] matrix = new int[rows, columns];
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

int[,] DeleteRowColumnMinMatrix(int[,] matrix)
{
  int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

  int minElement = matrix[0, 0];//мин элемент
  int minRow = 0;//индекс строки с мин элементом
  int minColumn = 0;//индекс столбца с мин элементом

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (matrix[i, j] < minElement) //поиск минимального элемента
      {
        minElement = matrix[i, j];//минимальный элемент
        minRow = i;//индекс строки
        minColumn = j;//индекс столбца
      }
    }
  }
  Console.WriteLine($"Минимальный элемент матрицы {minElement} с координатами ({minRow},{minColumn})");

  int rowOffset = 0;//смещение для исходной матрицы по строке
  int columnOffset = 0;//смещение для исходной матрицы по столбцу

  for (int i = 0; i < newMatrix.GetLength(0); i++)
  {
    if (i == minRow) rowOffset++;//если лишняя строка -> смещение = 1, иначе = 0
    for (int j = 0; j < newMatrix.GetLength(1); j++)
    {
      if (j == minColumn) columnOffset++;//если лишний столбец -> смещение = 1, иначе = 0
      newMatrix[i, j] = matrix[i + rowOffset, j + columnOffset];//записать в новую матрицу данные из старой с учетом всех смещений
    }
    columnOffset = 0;//обнулить смещение по столбцу
  }
  return newMatrix;
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
Console.WriteLine("\n");
int[,] newMatr = DeleteRowColumnMinMatrix(matr);
PrintMatrix(newMatr);





// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// const int ROWS = 3; //число строк
// const int COLUMNS = 4; //число столбцов

// int[,] FillMatrixRandomNumbers(int rows, int columns, int leftRange = 0, int rightRange = 9)
// {
//   int[,] matrix = new int[rows, columns];
//   Random rand = new Random();

//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i, j] = rand.Next(leftRange, rightRange + 1);
//     }
//   }

//   return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// int[,] sourceMatrix = FillMatrixRandomNumbers(ROWS, COLUMNS);
// PrintMatrix(sourceMatrix);

// int[] countingArray = new int[10]; //массив для записи повторений каждого элемента от 0 до 9 
// //см. как работает "сортировка подсчетом"


// for (int i = 0; i < sourceMatrix.GetLength(0); i++)
// {
//   for (int j = 0; j < sourceMatrix.GetLength(1); j++)
//   {
//     countingArray[sourceMatrix[i, j]]++;
//   }
// }

// for (int i = 0; i < countingArray.Length; i++)
// {
//   if (countingArray[i] != 0) Console.WriteLine($"Количество повторений для {i} = {countingArray[i]}");
// }
