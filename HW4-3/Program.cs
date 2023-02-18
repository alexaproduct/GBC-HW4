// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillMas (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int num = new Random().Next(0, 21);
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


int maxitem = 0;
int minitem = 0;
int maxdelta = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] >= maxitem) maxitem = arr[i];
}
Console.WriteLine("Максимальное число в массиве: " + maxitem);

for (int i = 0; i < arr.Length; i++)
{
    int delta1 = maxitem - arr[i];
    if (delta1 > maxdelta) maxdelta = delta1;
}
Console.WriteLine("Разница между макс и мин эл-тами массива: " + maxdelta);

// delta1 = maxitem - arr[i];
// if (delta1 > maxdelta) maxdelta = delta1;