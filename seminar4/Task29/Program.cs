// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GenerateArray(int lenArray)
{
    int[] arr = new int[lenArray];
    Random rnd = new Random();
    for (int i = 0; i < lenArray; i++)
    {
        arr[i] = rnd.Next(10);
    }
    return arr;
    
}

Console.Write("Введите длинну массива: ");
int lenArray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Массив длинной {lenArray}: [{string.Join(", ", GenerateArray(lenArray))}]");


