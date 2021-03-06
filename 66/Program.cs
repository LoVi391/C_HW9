// // // Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.

int m = 1;
int n = 15;
int result = 0;
Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна {Recursion(m, n)}.");

int Recursion(int firstNumber, int lastNumber)
{
    if (firstNumber == lastNumber + 1) return result;
    result += firstNumber;
    return Recursion(firstNumber + 1, lastNumber);
}