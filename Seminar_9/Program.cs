/*void ShowNums(int n)
{
    if (n != 1)
        ShowNums(n - 1);

    Console.Write(n + " ");
}

Console.Write("Input intenger positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowNums(num);*/


//Задайте значения M и N. Напишите программу,
//которая выведет все натуральные числа в промежутке от M до N.

void ShowNumbers(int n, int m)
{
    if (m != n) 
        ShowNumbers(n, m - 1);
        Console.Write($"{m} ");
}

Console.Write ("Input intenger max number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine (ShowNumbers(n,m));

//Напишите программу, которая будет принимать
//на вход число и возвращать сумму его цифр.
/* int Sum(int num)
{
    if (num == 0)
        return 0;
    return num % 10 + Sum(num / 10);
}
Console.Write ("Input intenger max number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ( Sum (num));*/

//Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
/*
double Degree(int A, int B)
{
    if (B > 0)
        return A * Degree(A, B - 1);
    else if (B < 0)
        return 1 / (A * Degree(A, -B - 1));
    else
        return 1;
}
Console.WriteLine ("Input intenger number: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Input intenger degree: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine (Degree(A,B));
*/