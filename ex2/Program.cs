// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.


int Akkerman(int m, int n) {

    if (m == 0)
    {
        return n + 1;
    }
    else if(m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}
int a = Akkerman(0,1);
System.Console.WriteLine($"a = {a}");

int b = Akkerman(2,0);
System.Console.WriteLine($"b = {b}");

int c = Akkerman(2,3);
System.Console.WriteLine($"c = {c}");

int d = Akkerman(3,2);
System.Console.WriteLine($"d = {d}");

