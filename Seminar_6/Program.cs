//Разворот массива
/*
int[] ReverseArray(int[] array)
{
    int temp;
    int j = array.Length - 1, i = 0;
    //вариант №1 с циклом while
    while (i < j)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;

        i++;
        j--;
    }
    /*  //вариант №1 с циклом for
    for(int i=0;i< array.Length/2;i++, j--)
    {
        temp = array[i];
        array[i]=array[j];
        array[j]=temp;
    }
    
    return array;
}
//Вызов метода
int[] myArray = { 2, 4, 6, 8,10};
myArray = ReverseArray(myArray);
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] = " ");
}
*/
//Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник с сторонами такой длины. (a+b>c)
/*
void  Triangle (int a, int b, int c)
{
    if(a+b>c && b+c>a && c+a>b) Console.WriteLine("Такой треугольник возможен");
    else Console.WriteLine ("Такой треугольник не возможен");
}

int a=3;
int b=5;
int c=10;
Triangle(a,b,c);
 */
//Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.

void Fibonacci(int n)
{
    int[] array = new int[n];
    array[0] = 0;
    array[1] = 1;
    Console.Write(array[0] + " " + array[1] + " ");
    for (int i = 2; i < n; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
        Console.Write(array[i] + " ");
    }   
}
int n = 7;
Fibonacci(n);

//Напишите программу, которая переводит десятичное число в двоичное.
/*
string BinaryNumber(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result;
        num/=2;
    }
    return result;
}
Console.WriteLine(BinaryNumber(10));
*/