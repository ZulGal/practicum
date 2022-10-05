// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray (double[] arr)
{
    for (int i=0;i<arr.Length; i++)
        arr[i] = new Random().NextDouble();
    
}
void PrintArray(double[] col)
{
    for (int i=0; i< col.Length; i++)
        Console.Write($"{Math.Round(col[i],3)} "); 
}

int MaxArray (double[] array)
{
    int index = 0;
    for (int i=1; i<array.Length; i++)
        if (array[i] > array[index])
            index = i;
    return(index);
}

int MinArray (double[] array)
{
    int index = 0;
    for (int i=1; i<array.Length; i++)
        if (array[i] < array[index])
            index = i;
    return(index);
}

double[] array = new double[7];
FillArray(array);
PrintArray(array);
int indexMin = MinArray(array);
int indexMax = MaxArray(array);

double d = array[indexMax] - array[indexMin];
Console.WriteLine();
Console.WriteLine($"Max = {Math.Round(array[indexMax],3)}");
Console.WriteLine($"Min =  {Math.Round(array[indexMin],3)}");
Console.WriteLine($"d = {Math.Round(d,3)}");