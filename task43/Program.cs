// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FillArray(double[,] col )
{
    for (int i=0; i<col.GetLength(0);i++)
        for (int j=0; j<col.GetLength(1); j++)
        {
            Console.WriteLine($"Введите для {i+1}-прямой:");
            if (j==0)
                Console.WriteLine($"          параметр k");
            else 
                Console.WriteLine($"          параметр b");
            col[i,j] = Convert.ToInt32(Console.ReadLine());
        }
}
void PrintArray(double[,] col)
{
    for (int i=0;i<col.GetLength(0); i++)
    {
        Console.WriteLine($"{i+1}-прямая: y = {col[i,0]}*x + {col[i,1]} "); 
    Console.WriteLine();
    }
}

bool CrossLine(double[,] arr)
{
    return(arr[0,0] != arr[1,0]);
}

double[,] lineParameter = new double[2,2];
FillArray(lineParameter);
PrintArray(lineParameter);

if (CrossLine(lineParameter))
    {
        double x = (lineParameter[1,1] - lineParameter[0,1])/(lineParameter[0,0] - lineParameter[1,0]);
        double y = lineParameter[0,0]*x + lineParameter[0,1];
        Console.WriteLine($"Координаты точки пересечения x={Math.Round(x,1)} y={Math.Round(y,1)}");
    }
else Console.WriteLine("Прямые параллельны  или совпадают");



