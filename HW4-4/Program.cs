// 1) Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200. 
// Обновите список только при первом вхождении числа 20. (можно использовать List<integer> )
// [21, 53,20, 56, 45,20] -> [21, 53,200, 56, 45,20]

void FillMas (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int num = new Random().Next(10, 22);
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
var k = int.Parse(Console.ReadLine()?? "");
var arr = new int[k];
FillMas(arr);
PrintMas(arr);

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == 20)
    {
        arr[i] = 200;
        break;
    }
}
PrintMas(arr);

/*
int imin = 0;

int maxdelta = 0;

int count = 0;

for (int i = 0; i < arr.Length; i++)
{
   if (arr[i] == 20)
   {
    count = count + 1;
    int ifirst = i;
    if (i > ifirst) i = i;
    Console.WriteLine(ifirst);
    Console.WriteLine(arr[ifirst]);
    if (arr.Length - ifirst > maxdelta) maxdelta = arr.Length - ifirst;
   }
}
if (count == 0) Console.WriteLine ("Нет 20 в массиве");
else
{
    Console.WriteLine();
    Console.WriteLine(maxdelta);
    int ifirst20 = arr.Length - maxdelta;
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[ifirst20] = 200;
        Console.Write(arr[i] + " ");
    }
}
*/