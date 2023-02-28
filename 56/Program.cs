// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillArrayRandom(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = new Random().Next(0, 10);
        }
    }
    return coll;
}

int[,] PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],2}");
        }
        Console.WriteLine();
    }
    return array;
}

Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

//int[,] array = new int[4, 4];
int[,] array = new int[m, n];
FillArrayRandom(array);
PrintArr(array);

int summ;
int itog = 9999999;
int k=0;

for (int i = 0; i < array.GetLength(0); i++)
{
    summ = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
                summ += array[i, j];
    }
    //Console.WriteLine(summ);
    if (summ < itog)
    {
       itog = summ;
       k = i;
    }
}


Console.WriteLine($"строка {k + 1}, сумма равна {itog}");


















