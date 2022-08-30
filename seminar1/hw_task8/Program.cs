// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count >=1 && count <= number)
{
  Console.Write(count + ", ");
  count ++;
}
if (number <= 0)
{
  Console.WriteLine("число должно быть положительное");
}