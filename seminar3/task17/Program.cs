// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координау по X:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координау по Y:");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
  Console.WriteLine("Точка находится в 1 координатной четверти");
}
else if (x < 0 && y > 0)
{
  Console.WriteLine("Точка находится во 2 координатной четверти");
}
else if (x < 0 && y < 0)
{
  Console.WriteLine("Точка находится в 3 координатной четверти");
}
else if (x > 0 && y < 0)
{
  Console.WriteLine("Точка находится в 4 координатной четверти");
}
else
{
  Console.WriteLine("Введена нулевая координата по X и/или Y");
}