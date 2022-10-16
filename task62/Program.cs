// Задача 62. Напишите программу, которая заполнит спирально 
// массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
void FillMatrix(int[,] matr, int iBegin, int iEnd, int jBegin, int jEnd)
{
    if (jBegin < jEnd)
        for (int j = jBegin + 1; j <= jEnd; j++)
            matr[iEnd, j] = new Random().Next(1, 9);
    else
        if (jBegin>jEnd)
            for (int j = jBegin - 1; j >= jEnd; j--)
                matr[iEnd, j] = new Random().Next(1, 9);

    if (iBegin < iEnd)
        for (int i = iBegin + 1; i <= iEnd; i++)
            matr[i, jEnd] = new Random().Next(1, 9);
    else
        if (iBegin>iEnd)
            for (int i = iBegin - 1; i >= iEnd; i--)
                matr[i, jEnd] = new Random().Next(1, 9);

}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int m = 4;
int[,] matrix = new int[m, m];
int iBegin = m/2;
int jBegin = m/2;
matrix[iBegin,jBegin] = 9;
int iEnd = iBegin;
int jEnd = 0;

for (int k = 1; k <= m; k++)
{
    if (k % 2 != 0)
    {
        jEnd = jBegin - k;
        FillMatrix(matrix, iBegin, iEnd, jBegin, jEnd);
        PrintMatrix(matrix);
        jBegin = jEnd;

        iEnd = iBegin - k;
        FillMatrix(matrix, iBegin, iEnd, jBegin, jEnd);
        PrintMatrix(matrix);
        iBegin = iEnd;
    }
    else
    {
        jEnd = jBegin + k;
        if (jBegin ==0)
            jEnd = jBegin+k-1;    
        FillMatrix(matrix, iBegin, iEnd, jBegin, jEnd);
        PrintMatrix(matrix);
        jBegin = jEnd;
        
        if ((iBegin!=0))
        {
            iEnd = iBegin + k;
            FillMatrix(matrix, iBegin, iEnd, jBegin, jEnd);
            PrintMatrix(matrix);
            iBegin = iEnd;
        }
    }
}




