/*
Задача 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 - max = 7
a = 2 b = 10 - max = 10
a = -9 b = -3 - max = -3
*/


Console.Write("Input number 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number 2: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Большее число: " + a + ", А меньшее число: " + b);
}

else if (a < b)
{
    Console.WriteLine("Большее число: " + b + ", А меньшее число: " + a);
}

else if (a == b)
{
    Console.WriteLine("Числа равны!");
}






/*
Задача 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 - 7
44 5 78 - 78
22 3 9 - 22
*/


Console.Write("Input number 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number 2: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number 3: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}

Console.WriteLine("Максимальное число: " + max);






/*
Задача 6 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 - да
-3 - нет
7 - нет
*/


Console.Write("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N % 2 == 0)
{
    Console.WriteLine("Число " + N + " - чётное");
}

if (N % 2 != 0)
{
    Console.WriteLine("Число " + N + " - не чётное");
}






/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/


Console.Write("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
string p = "";
while (i <= N)
{
    if (i % 2 == 0)
    {
        p = (p + i + " ");
    }
    i++;
}
Console.WriteLine(p);
