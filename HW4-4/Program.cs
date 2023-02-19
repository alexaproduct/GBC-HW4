// 1) Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200. 
// Обновите список только при первом вхождении числа 20. (можно использовать List<integer> )
// [21, 53,20, 56, 45,20] -> [21, 53,200, 56, 45,20]

void FillMas (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int num = new Random().Next(19, 22);
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

for (int i = 0; i < arr.Length-1; i++)
{
    if (arr[i] == 20) arr[i] = arr[i]+180;
    arr[i] = arr [i];
    Console.Write(arr[i] + " ");
}

