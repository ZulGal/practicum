// Задача 58: Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
void ProductMatrix(int[,] matrA,
                    int[,] matrB,
                    int[,] matrC)
{
    for (int i = 0; i < matrA.GetLength(0); i++)
        for (int j = 0; j < matrB.GetLength(1); j++)
        {
            matrC[i, j] = 0;
            for (int k = 0; k< matrB.GetLength(0);k++)
                matrC[i,j] = matrC[i,j] + matrA[i,k]*matrB[k,j];
        }
}                    
int m = 2;
int n = 2;
int[,] matrixA = new int[m, n];
int[,] matrixB = new int[n, m];
int[,] matrixC = new int[m, n];

FillMatrix(matrixA);
FillMatrix(matrixB);
PrintMatrix(matrixA);
PrintMatrix(matrixB);

ProductMatrix(matrixA,matrixB,matrixC);
PrintMatrix(matrixC);
