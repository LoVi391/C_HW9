// // Задача 64 Задайте значение N. Напишите программу, которая выведет все
//натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.




Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.Write("1 = " + 1 + "; N = " + numberN + " -> ");

if (1 > numberN)
{
    for (int i = 1; i >= numberN; i--)
    {
        if (i == numberN)
        {
            Console.Write(i);
        }
        else
        {
            Console.Write(i + ", ");
        }
    }
}
else
{
    for (int i = 1; i <= numberN; i++)
    {
        if (i == numberN)
        {
            Console.Write(i);
        }
        else
        {
            Console.Write(i + ", ");
        }
    }
}