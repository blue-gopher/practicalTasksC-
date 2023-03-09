// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void NumberCubes(int num) 
{   
    int[] nums = new int[num];
    for (int i = 1; i <= num; i++) 
    {
        nums[i-1] = Convert.ToInt32(Math.Pow(i, 3));
    }
    string numsStr = string.Join(',', nums);
    Console.WriteLine(numsStr);
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

NumberCubes(num);