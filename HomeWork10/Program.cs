//Задача №1
//Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
//Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1
string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        words[i] = Console.ReadLine();
    }

    return words;
}

int StartingWithVowelCount(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        char l = array[i].ToLower()[0];
        if(l == 'a' || l == 'e' || l == 'i' || l == 'o' || l == 'u' || l == 'y') count++;
    }
    return count;
}

Console.Write("Input number of words: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] words = CreateStringArray(size);

Console.WriteLine($"{StartingWithVowelCount(words)} words are starting with a vowel letter in the array.");


//Задача №2
//Задайте массив строк. Напишите программу, которая генерирует новый массив,
//объединяя элементы исходного массива попарно.
//Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}
/*
string [] IntegratedArray(string [] array)
{
    int addition = 0;
    if (array.Length % 2 != 0) addition = 1;    
    string [] newArray = new string [array.Length / 2 + addition];
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i * 2 + 1 < array.Length) newArray[i] = array[i * 2] + array[i * 2 + 1];
        else newArray[i] = array [i * 2];
    }
    return newArray;
}

void PrintStringArray(string [] array)
{
    foreach (string word in array) 
        Console.Write(word + ", ");
}

string [] array = {"qwe", "wer", "ert", "aty","Abb","sAAdd", "ss"};
PrintStringArray(array);
Console.WriteLine();
string [] newArray = IntegratedArray(array);
PrintStringArray(newArray);
*/
