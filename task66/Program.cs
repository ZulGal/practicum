// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumNumbers(int m, int n)
{
    if (m==n) return m;
    else
    {
        return m  + SumNumbers(m+1,n);
    } 
}
int M = 4;
int N = 8;
int summa = SumNumbers(M,N);
Console.WriteLine(summa);