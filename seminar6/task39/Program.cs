﻿// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1][6 7 3 6] -> [6 3 7 6]

int[] GetRandomArray(int size, int leftRange, int rightRange) /* метод 
 создания массива с аргументами размера, и диапазоном*/
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

void Reverse(int[] array) //метод переворота массива
{
    for (int i = 0; i > array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}

const int SIZE = 5;
const int RIGHTRANGE = 150;
const int LEFTRANGE = 0;
int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", arr));

Reverse(arr);
Console.WriteLine();
Console.WriteLine(string.Join(", ", arr));
