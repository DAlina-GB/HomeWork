//Получаем натуральное число, Найти сумму всех цыфр в этом числе
//Например 1234, это 4+3+2+1=10
/*
int FindSumOfdigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10; // sum += num % 10; - то же самое
        num = num / 10;      // num/=10;
    }
    return sum;
}

Console.Write ("Input number: ");                  //запрос числа
int n = Convert.ToInt32(Console.ReadLine());

int result = FindSumOfdigits(n);                 // вызов метода, который мы сделали результом
Console.WriteLine ($"Сумма цыфр в числе {n} равна {result}"); */

// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// Напишите программу, которая принимает на вход число и выдаёт кол-во цифр в числе.
/*
int Kolichestvo(int N)
{
    int count = 0;
    while (N > 0)
    {
        count = count + 1;
        N = N / 10;
    }
    return count;
}
Console.Write ("Input number: ");                  
int n = Convert.ToInt32(Console.ReadLine());

int result = Kolichestvo(n);                 
Console.WriteLine (result); */

//Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.
/*int size = 8;                      // Объявление массива
int[] array = new int[size];
                                            // Как работать с массивом, как по нему пробегаться
for (int i = 0; i < size; i = i + 1) 
{                                               //Цикл 1
    array[i] = new Random().Next(0,2);          //new Random().Next(0,2) это цикл например [1 0 0 0 1 0 1 1]
}                                               //new Random().Next(0,4) это цикл например [3 2 1 0 2 3 3 1]
for (int i = 0; i < size; i++)
{                                                    //Цикл 2
    Console.Write (array[i]+" ");
} */