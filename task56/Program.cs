// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка
void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
            matr[i, j] = new Random().Next(1, 10);
}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j]} ");
        Console.WriteLine();
    }
}
int m = 3;
int n = 4;
int[,] matrix = new int[m, n];
FillMatrix(matrix);
PrintMatrix(matrix);

int[] sum = new int[m];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    sum[i] = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
        sum[i] += matrix[i, j];
}

int min = sum[0];
int indexMin = 0;
for (int i = indexMin + 1; i < sum.Length; i++)
    if (sum[i] < min)
        indexMin = i;
Console.WriteLine($"{indexMin} строка имеет наименьшую сумму");