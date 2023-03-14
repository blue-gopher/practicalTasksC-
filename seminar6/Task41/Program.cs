// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

int countPositiveNumbers = 0;
int num = 0;

for (int i = 0; i < M; i++)
{
    Console.Write($"Введите {i+1} число: ");
    num = Convert.ToInt32(Console.ReadLine());
    if (num > 0) countPositiveNumbers++;
}

Console.WriteLine($"Колличество чисел больше 0 = {countPositiveNumbers}");