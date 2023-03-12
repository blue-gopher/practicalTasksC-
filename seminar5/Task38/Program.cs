// Задача 38: Задайте массив вещественных чисел(тип double). Найдите разницу между максимальным и минимальным элементов массива.
// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

double[] FillArray(int lenArray) 
{
    Random rdm = new Random();
    double[] arr = new double[lenArray];
    for (int i = 0; i < lenArray; i++)
    {
        arr[i] = Math.Round(rdm.NextDouble() * 10, 2);
    }
    return arr;
}

double DifferenceBetweenMaxAndMin(double[] array, int lenArray)
{
    if (lenArray < 2) return 0;
    return array.Max() - array.Min();
}

Console.Write("Введите длинну массива: ");
int lenArray = Convert.ToInt32(Console.ReadLine());
double[] array = FillArray(lenArray);

double difference = DifferenceBetweenMaxAndMin(array, lenArray);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива [{string.Join("; ", array)}] = {difference}.");
