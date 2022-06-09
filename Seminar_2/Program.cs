//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int OutPutsDelets()
{ 
 int num = new Random().Next(100,1000);
Console.WriteLine ($"Current number is {num}");

 int sot = num / 100;
 int ed = num % 10;

 int result = sot * 10 + ed;
 return result;
}
*/

//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. 
//Если второе число не кратно числу первому, то программа выводит остаток от деления.

/*
string Divisible (int arg1,int arg2)
{ if(arg2%arg1 == 0)
    {return "Second divisible first";}
 else {return Convert.ToInt32 arg2%arg1;}
}

Console.Write("Input First nimber: ");
int arg1 = int.Parse(Console.ReadLine());
Console.Write("Input Second nimber: ");
int arg2 = int.Parse(Console.ReadLine()); 
*/
//Напишите программу, которая принимает на вход число и проверяет,кратно ли оно одновременно 7 и 23
Console.WriteLine(CutNumber());
string IsAliquot (int num1, int num2)
{
    if(num2 % num1 == 0 ) return "True";
    else return ("Fals, rest num is" +›)
}