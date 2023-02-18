// Задача 1 - Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void FillMas (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int num = new Random().Next(100, 1000);
        arr[i] = num;
    }
}

 void PrintMas (int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите размерность массива: ");
int k = int.Parse(Console.ReadLine()?? "");
int[] arr = new int[k];
FillMas(arr);
PrintMas(arr);

int counteven = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]%2 == 0)
    {
        counteven = counteven + 1;
    }
    else
    {
        counteven = counteven + 0;
    }
}

Console.WriteLine(counteven);