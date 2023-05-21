// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 4, 76, 3 -> [1, 2, 5, 7, 19, 4, 76, 3]
// 6, 1, 33, 43, 12, 3, 2, 9 -> [6, 1, 33, 43, 12, 3, 2, 9]


const int lengthArr = 8;
int[] array = new int[lengthArr];
GetArr(array);
Console.WriteLine("Введенный массив : ");
PrintArr(array);

int[] GetArr(int[] arr2)
{
    Console.WriteLine("Введите массив из 8 элементов:");
    for (int i = 0; i < arr2.Length; i++)
    {
        int number = Convert.ToInt32(Console.ReadLine()!);
        arr2[i] = number;
    }
    return arr2;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"[{arr[i]}] ");
    }
    Console.WriteLine();
}

