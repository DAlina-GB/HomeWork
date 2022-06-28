//Задача №1
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 21, -7, 567, 89, 223-> 3

Console.Write($"Input the quantity of numbers to check: ");
int m = Convert.ToInt32(Console.ReadLine());
int[]Array1 = new int[m];

void InputNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Input {i+1} number: ");
    Array1[i] = Convert.ToInt32(Console.ReadLine());
  }
}
int OverZero(int[] Array1)
{
    int num2 = 0;
    for (int i = 0; i < Array1.Length; i++ )
    {
    if (Array1[i] > 0)
    {
      num2++;
    }
  }
  return num2;
}
InputNumbers(m);

Console.WriteLine($"Quantity of numbers over zero: {OverZero(Array1)} ");

