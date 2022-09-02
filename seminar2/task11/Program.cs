// Задача 11: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = rand.Next(100,1000); // [100,1000) числа от 100 до 999

Console.WriteLine($"Сгенерировалось случайное число: {number}");
int digit3 = number % 10; //остаток от деления на 10
int digit1 = number / 100;//целое от деления на 10


// Console.WriteLine(digit1);
// Console.WriteLine(digit3);

System.Console.WriteLine("Новое число: "+ digit1 + digit3);