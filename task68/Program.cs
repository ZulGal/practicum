// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int i,int j)
{
    if (i==0)
        return j+1;
    else 
        if (j==0)
            return Akkerman(i-1,1);
        else return Akkerman(i-1,Akkerman(i,j-1));       
}
int m = 3;
int n = 2;
int a = Akkerman(m,n);
Console.WriteLine(a);
