// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
double Average(int [] col)
{
    double sum = 0;
    for (int i=0; i<col.Length; i++)
        sum +=col[i];
    return(sum/col.Length);
}

int m=3;
int n=4;
int [,] matrix = new int[m,n];
int [] array = new int[m];

FillArray(matrix);
PrintArray(matrix);

Console.Write("Среднее арифметическое каждого столбца: ");
for (int j=0; j< matrix.GetLength(1); j++)
{
    for (int i=0; i<matrix.GetLength(0); i++)
        array[i] = matrix[i,j];
    
    double mean = Average (array);    
    Console.Write($"{Math.Round(mean,2)} ");
}

