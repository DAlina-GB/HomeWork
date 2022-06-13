/*int FindQuart(int x, int y)
{
    if(x>0 && y>0) return 1;
    if(x<0 && y>0) return 2;
    if(x<0 && y<0) return 3;
    if(x>0 && y<0) return 4;

    return -1;

}
int result = FindQuart (-4,0);
if (result == -1) Console.WriteLine ("Данная точка расположенная на осях");
else Console.WriteLine ($"Точка находиться в {result} четверти");
*/
void Quard (int x)
{
    if ( x>=1 && x<=4 )
 
    if (x == 1) Console.WriteLine ("Допустимое значение положительные x y");
    if (x == 2) Console.WriteLine ("Допустимое значение положительный y и отрицательный x ");
    if (x == 3) Console.WriteLine ("Допустимое значение отрицательные x и y ");
    if (x == 4) Console.WriteLine ("Допустимое значение положительный x и отрицательный y ");
    
    else Console.WriteLine ("Недопустимое значение");
 
}
int x;
Console.WriteLine ("Input quard number  ");
x = Convert.ToInt32(Console.ReadLine());
