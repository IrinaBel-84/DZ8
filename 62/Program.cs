//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

int[,] PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],2} ");
        }
        Console.WriteLine();
    }
    return array;
}

int row = 4;
int[,] array = new int[row, row];
int x1 = 0;
int x4 = 0;
int y1 = 0;
int y4 = 0;
int count = 1;
int i =0;
int j = 0;

while (count <= row*row)
{
    array[i,j] = count;
    
    if (i == x1 && j < row - y4 - 1)
        j = j + 1;
    else if (j == row - y4 - 1 && i < row - x4 - 1)
        i = i + 1;
    else if (i == row - x4 - 1 && j > y1)
        j = j - 1;
    else
        i = i - 1;           

    if ((i == x1 + 1) && (j == y1) && (y1 != row - y4 - 1))
    {
        x1 = x1 + 1;
        x4 = x4 + 1;
        y1 = y1 + 1;
        y4 = y4 + 1;
    }

    count= count + 1;
}


PrintArr(array);