/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


int [] FillArray(int size)
{
    int[] ar = new int[size];
    Random nd = new Random();
    for (int i = 0; i < ar.Length; i++)
    {
        ar[i]= nd.Next(-10,10);
    }
    return ar;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i] } ");
    }
    Console.WriteLine();
}
int Sum(int[] a)
{
    int sum = 0;
    for (int i = 1; i < a.Length; i+=2)
    {
        sum = sum + a[i];
    }
    return sum;
}

int[] array = FillArray(5);
PrintArray(array);
int s = Sum (array);
Console.WriteLine($"Сумму элементов, стоящих на нечётных позиция, равна {s}");