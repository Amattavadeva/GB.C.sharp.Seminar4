/* Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B. */

/* Console.Write("Введите число А : ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите степень : ");
int B = int.Parse(Console.ReadLine());

void Fill(int num, int degree)
{
    int num_n = 1;
    for (int i = 0; i < degree; i++)
    {
        num_n *= num;
    }
    Console.WriteLine("Ответ: " + num_n);
}
Fill(A, B); */


/* Задача 27: Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе. */

/* Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int Function(int num)
{
    int total = 0;
    while (num > 0)
    {
        total = total + num % 10;
        num = num / 10;
    }
    return total;
}
Console.WriteLine("Сумма цифр в числе = " + Function(num)); */


/* Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран. */

Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальное число в массиве");
int maxNum = int.Parse(Console.ReadLine());

int[] mass = new int[num];
FillArray(mass);
PrintArray(mass);

void FillArray(int[] array)
{
    int length = array.Length;
    for (int index = 0; index < length; index++)
    {
        array[index] = new Random().Next(0, maxNum + 1);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}