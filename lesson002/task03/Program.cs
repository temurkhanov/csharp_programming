﻿int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        Console.Write($"{numbers[i]} ");
    }
}