/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int [] FillArray(int ar)
{
    int [] array = new int[ar];
    Random number = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=number.Next(100,1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}

int EvenNumber(int [] arr)
{
    int even = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0)
        {
            even +=1;
        }
    }
    return even;
}
int [] ar = FillArray(4);
PrintArray (ar);
int s = EvenNumber(ar);

Console.WriteLine($"Количество четных элементов в массиве равно {s}");