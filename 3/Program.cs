﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число: ");

        int number = Convert.ToInt32(Console.ReadLine());


        for (int i = 1; i <= number; i++)

            Console.Write($"{Math.Pow(i, 3)}. ");
    }
}