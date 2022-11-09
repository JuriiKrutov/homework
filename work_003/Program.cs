// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array =new int[2, 2];

int[,] massiv = new int[2, 2];

int[,] compArray = new int [2, 2];

FillArray(array);
FillArray(massiv);
PrintArray(array);
System.Console.WriteLine();
PrintArray(massiv);
System.Console.WriteLine();

for (int i = 0; i < compArray.GetLength(0); i++)
{
    for (int j = 0; j < compArray.GetLength(1); j++)
    {           
        for (int n = 0; n < array.GetLength(1); n++)
        {
            compArray[i, j] += array[i, n] * massiv[n, j];
        }
    }
}

PrintArray(compArray);
