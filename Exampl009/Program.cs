/*
void Metod1()
{
    Console.WriteLine("Автор...");
}
Metod1();
*/
/*
void Metod2(string msg)
{
    Console.WriteLine(msg);
}
Metod2("Текст сообщения");
*/
/*
void Metod21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Metod21("Текст", 4);
*/
/*
int Metod3()
{
    return DateTime.Now.Year;
}
int year = Metod3();
Console.WriteLine(year);
*/
/*
string Metod4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Metod4(10, "z");
Console.WriteLine(res);
*/
/*
string Metod4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Metod4(10, "z");
Console.WriteLine(res);
*/
/*
for(int i = 2; i<=10; i++)
{
    for(int j = 2; j<=10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
*/
/*
string text = "- Я думаю, сказал князь, улыбаясь, - что,"
+ "ежели бы вас послали вместо нашего милого Винцергероде"
+ "вы бы взяли приступом согласие прусского короля"
+ "Вы так красноречивы. Вы дадите мне чаю?";

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i=0; i<length; i++)
    {
        if(text[i]==oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replase(text,  ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'с', 'С');
Console.WriteLine(newText);
*/
/*
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;

        for (int j = i+1; j<array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j; 
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/
/*
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int maxPosition = i;

        for (int j = i+1; j<array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j; 
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/

/*// вывод элементов массива на экран
int[] arr = {3, 1, 8, 7, 2, 6, 5, 9, 4};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
//Метод нахождения значения максимального элемента массива
void Max(int[] array)
{
    int Max = 0;
    int maxPosition = 0;
    for (int i = 0; i < array.Length;)
    { 
        if(array[i] > array[maxPosition]) maxPosition = i;
        i++;
        Max = array[maxPosition];
    }
    Console.WriteLine(Max);
}

// Метод нахождения значения минимального элемента массива
void Min(int[] array)
{
    int Min = 0;
    int minPosition = 0;
    for (int i = 0; i < array.Length;)
    { 
        if(array[i] < array[minPosition]) minPosition = i;
        i++;
        Min = array[minPosition];
    }
    Console.WriteLine(Min);
}
void SumMinMax(int[] array)
{
    int sum = 0;
    int min = 0;
    int max = 0;
    int i = 0;

    for(i = 0; i < array.Length;)
    {
        if(array[i] < array[min]) min = i;
        if(array[i] > array[max]) max = i;
        i++;
    }
    Console.WriteLine(min);
    Console.WriteLine(max);
    for(i = min; i <= max;)
    {
        sum =  sum + array[i];
        i++;
    }    
        for(i = max; i <= min;)
        {
            sum = sum + array[i];
            i++;
        }
    Console.WriteLine();
    Console.WriteLine(sum);
}

PrintArray(arr); // запуск метода вывода на экрвн элементов массива
//Max(arr); // запуск метода вывода на экран значения максимального элемента массива
//Min(arr); // запуск метода вывода на экран значения минимального элемента массива
SumMinMax(arr);
*/
/*
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
void Step(double a, double b)
{
    double c = Math.Pow(a, b);
    Console.WriteLine(c);
}
Console.WriteLine("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
Step(a, b);
*/

/*
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void Summa (int a)
{
    int sum = 0;
    int n;
    while(a < 1)
    {
        n = a%10;
        sum = sum + n;
        a = a/10;
    }
Console.WriteLine(sum);
}
Console.WriteLine("Input num: ");
int num = Convert.ToInt32(Console.ReadLine());
Summa(num);
Console.WriteLine();
*/

/*
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
*/
/*
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Stepen(int a, int b)
{
    int current = 0;
    int proisv = 1;
    while(current < b)
    {
        proisv = proisv * a;
        current ++;
    }
    return proisv;
}
Console.WriteLine("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"result stepen is {Stepen(a, b)}");
*/

/*
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Summe(int a)
{
    int sum = 0;
    while(a > 0)
    {
        int number = a%10;
        sum = sum + number;
        a = a/10;
    }   
    return sum; 
}   
Console.WriteLine("Input num: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"namber {num} result summe is {Summe(num)}");
*/

/*
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);
*/