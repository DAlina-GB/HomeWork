int[] arr = {1,4,2,1,2};
void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i =0; i<count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void SeLectionSoft(int[] array)
{
    for (int i=0; i < array.Length-1; i++)
    
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition]=temporary;

 }

PrintArray(arr);
SeLectionSoft(arr);

PrintArray(arr);