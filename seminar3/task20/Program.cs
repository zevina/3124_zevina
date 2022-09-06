// Задача 20: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату Х для точки А:");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y для точки А:");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Х для точки B:");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y для точки B:");
int yb = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2));
Console.WriteLine($"Расстояние между точками А и В: {distance:f2}");