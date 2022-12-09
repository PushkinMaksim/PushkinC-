/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив
из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с 
клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/
string[] Start (int size)
{
    string[] array = new string[size];
    for(int i = 0; i < size; i++)
        {
            Console.Write("Введите строку №{0}:\r\n   ", i+1);
            string num = Console.ReadLine();
            array[i] = num;
        }
    return array;
}

// вывод массива в терминале
void ShowArray(string[] array)
{
    for(int i =0; i < array.Length; i++)
        Console.Write(array[i]+"," + "  ");
    Console.WriteLine();    
}   

string[] NewMass(string[] array, int m)
{
    int length = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        if(array[i].Length <= m)
            length++;
    }
    string[] array1 = new string[length];
    int count = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        if(array[i].Length <= m)
        {
            array1[count] = array[i];
            count ++;
        }
    }
    return array1;
}
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну строк: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] myArray = Start(n);
Console.WriteLine();
ShowArray(myArray);
string[] myArray1 = NewMass(myArray, m);
Console.WriteLine();
ShowArray(myArray1);
