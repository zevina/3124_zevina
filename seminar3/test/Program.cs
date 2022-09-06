            string a;
            int[] b = new int[100];
            int i=0;
Console.WriteLine("Введите элементы массива. По окончанию введите end");
            while ((a = Console.ReadLine()) != "end") //Получаем строку и проверяем ее содержание
                b[i++] = Convert.ToInt32(a); //в строке нет "конца" - значит конвертим и пишем в массив
 
            // for (int k = 0; k < i; k++) //вывод заполненных ячеек массива
            //     Console.WriteLine(b[k]);
 
            Console.ReadKey(true);
            Console.WriteLine(" ");

            int n = b.Length;
            for (int s = 0; s < n; s++) //вывод заполненных ячеек массива
                {
                  int t = b[s];
                  b[s] = b[n-1-s];
                  b[n-1-s] = t;
                }
foreach (int el in b)
{
  Console.WriteLine(el);
}
