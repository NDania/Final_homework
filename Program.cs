// Написать программу, которая из имеющегося массива строк формирует массив
// из строк, длина которых меньше либо равна 3 символа.

Console.Clear();

Console.WriteLine("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
string[]text = new string[n];
int m = 0;
for(int i = 0; i < text.Length; i++)
{
    Console.WriteLine("Введите элемент массива: ");
    text[i] = Console.ReadLine();
    if(text[i].Length < 4)
        m++;
}
Console.WriteLine($"[{string.Join(", ", text)}]");

string[]newarray = new string[m];
int j = 0;
for(int i = 0; i < text.Length; i++)
{
    if(text[i].Length < 4)
    {
        newarray[j] = text[i];
        j++;
    }
}
Console.WriteLine($"[{string.Join(", ", newarray)}]");
