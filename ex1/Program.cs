// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void Recursion(int m, int n) {
    System.Console.WriteLine(m);
    if (m < n)
    {
        Recursion(m + 1, n);
    }
}


Recursion(10, 50);
