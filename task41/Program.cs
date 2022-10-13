// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int m=5;
int[] array = new int[m];

int num = 1;
int count = 0;
int i=0;
while (num != 0 & i <array.Length)
{
    Console.WriteLine("Введите положительное или отрицательное целое число," );
    Console.WriteLine($"количество чисел <={array.Length}, конец ввода - 0");
    num = Convert.ToInt32(Console.ReadLine());
    array[i] = num;
    if (array[i] >0 )
        count++;
    i++;
}  
Console.WriteLine($"Количество введенных положительных чисел = {count}");