// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray (int[] arr)
{
    for (int i=0;i<arr.Length; i++)
        arr[i] = new Random().Next(100,1000);
}
void PrintArray(int[] col)
{
    for (int i=0; i< col.Length; i++)
        Console.Write($"{col[i]} "); 
}

int[] array = new int[7];
FillArray(array);
PrintArray(array);

int count = 0;
for (int i=0; i< array.Length; i++)
    {
        if (array[i]%2 == 0)
           count++; 
    }

Console.WriteLine();
Console.WriteLine(count);

