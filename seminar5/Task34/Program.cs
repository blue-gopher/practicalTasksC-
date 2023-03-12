// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int lenArray) 
{
    Random rdm = new Random();
    int[] arr = new int[lenArray];
    for (int i = 0; i < lenArray; i++)
    {
        arr[i] = rdm.Next(100, 1000);
    }
    return arr;
}

int CountEvenNumbers(int[] array, int lenArray)
{
    int count = 0;
    foreach (int num in array)
    {
        if (num % 2 == 0) count++;
    }
    return count;
}

Console.Write("Введите длинну массива: ");
int lenArray = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(lenArray);

int count = CountEvenNumbers(array, lenArray);
Console.WriteLine($"Массив: [{string.Join(", ", array)}] содержит {count} четных(ое) чисел(о,ла).");
