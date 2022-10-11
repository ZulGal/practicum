// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArray(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
        for (int j=0; j<matr.GetLength(1); j++)
            matr[i,j] = new Random().Next(0,10); 
}

void PrintArray(int [,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
            Console.Write($"{matr[i,j]} ");
        Console.WriteLine();
    }    
}

int m=3;
int n=4;
int [,] matrix = new int[m,n];

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine($"Введите строку элемента матрицы {m}x{n}");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите столбец элемента матрицы {m}x{n}");
int column = Convert.ToInt32(Console.ReadLine()); 

if ((row < m) & (column <n))
    Console.WriteLine($" a[{row},{column}]={matrix[row,column]}");
else Console.WriteLine($"Нет элемента a[{row},{column}]");
