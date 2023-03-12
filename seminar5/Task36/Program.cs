// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int lenArray) 
{
    Random rdm = new Random();
    int[] arr = new int[lenArray];
    for (int i = 0; i < lenArray; i++)
    {
        arr[i] = rdm.Next(0, 100);
    }
    return arr;
}

int SumOfElementsInOddPosition(int[] array, int lenArray)
{
    if (lenArray < 2) return 0;

    int sum = 0;
    for (int i = 1; i < lenArray; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

Console.Write("Введите длинну массива: ");
int lenArray = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(lenArray);

int sum = SumOfElementsInOddPosition(array, lenArray);
Console.WriteLine($"Сумма элементов массива [{string.Join(", ", array)}], стоящих на нечётных позициях = {sum}.");
