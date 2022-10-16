// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
void FillMatrix (int[,] arr)
{
    for (int i=0; i<arr.GetLength(0); i++)
        for (int j=0; j<arr.GetLength(1); j++)
            arr[i,j] = new Random().Next(1,10);
}

void PrintMatrix(int[,]col)
{
    for (int i=0; i<col.GetLength(0); i++)
    {
        for (int j=0; j<col.GetLength(1); j++)
            Console.Write($"{col[i,j]} ");
        Console.WriteLine();
    }
}

void CopyToArray(int[,] matr, int[] arr, int i)
{
    for(int j=0; j<matr.GetLength(1); j++)
    {
        arr[j] = matr[i,j];
    }
}

void SortArray(int[]col)
{
    for (int i=0; i<col.Length; i++)
    {
        int maxPosition = i;
        for (int j=i+1; j<col.Length;j++)
            if (col[j]>col[maxPosition]) maxPosition = j;
        int temp = col[i]; col[i]= col[maxPosition]; col[maxPosition] = temp;   
    }
}
void CopyToMatrix(int[,] matr, int[] arr, int i)
{
    for(int j=0; j<matr.GetLength(1); j++)
    {
        matr[i,j] = arr[j];
    }
}
 
int m = 3;
int n = 4;
int[,] matrix = new int[m,n];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

int[] array = new int[n];
for (int i=0; i<matrix.GetLength(0);i++)
{
    CopyToArray(matrix, array,i);
    SortArray(array);
    CopyToMatrix(matrix, array, i);
}
PrintMatrix(matrix);
