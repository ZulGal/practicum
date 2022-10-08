// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[]arr)
{
    for (int i=0; i<arr.Length; i++)
        arr[i] = new Random().Next(1,10);
}
void PrintArray(int[]col)
{
    for (int i = 0; i<col.Length; i++)
        Console.Write($"{col[i]} ");
}
int[] array = new int[6];
FillArray(array);
PrintArray(array); 

int sum = 0;

for (int i=0; i<array.Length; i++)
{
    if (i%2 != 0)
        sum +=array[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях= {sum}");