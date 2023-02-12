/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/


int [] FillArray(int size)
{
    int[] ar = new int[size];
    Random nd = new Random();
    for (int i = 0; i < ar.Length; i++)
    {
        ar[i]= nd.Next(-5,100);
    }
    return ar;
}

(int, int) MM (int[]array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        } 
        else if (array[i]<min)
        {
            min = array[i];
        }     
    }
    return (max,min);
}
int[] array = FillArray(10);
Console.WriteLine(string.Join(", ", array));
(int max, int min) = MM(array);
int a = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {a}");