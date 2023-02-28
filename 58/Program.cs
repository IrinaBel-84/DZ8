//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

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

Console.WriteLine("Введите 1ю размерность 1й матрицы ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2ю размерность 1й матрицы ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 1ю размерность 2й матрицы ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2ю размерность 2й матрицы ");
int n2 = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[m1, n1]; // первая матрица
FillArrayRandom(array1);
Console.WriteLine("1 матрица");
PrintArr(array1);

int[,] array2 = new int[m2, n2]; // вторая матрица
FillArrayRandom(array2);
Console.WriteLine("2 матрица");
PrintArr(array2);

if (n2 != m1)
{
   Console.WriteLine("Размерности матриц не совпадают");
}
else
{
    int[,] arr = new int[m1, n2]; // итоговая матрица


    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(1); k++)
            {
                arr[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    Console.WriteLine("Произведение матриц");
    PrintArr(arr);
}
