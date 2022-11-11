//Урок 5. Функции продолжение

/*
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Генерация массива
int[] CreateRandomeArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // инициализация миссива размера size
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
return array;
}

// вывод массива в терминале
void ShowArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();    
}   

//Запрос элементов массива
Console.WriteLine("Input a number of elemrnts: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());       // для генерации з-х значных чисел вводим в min и max числа от 100 до 1000
Console.WriteLine("Input a max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

//Запуск метода генерации и вывода элементов массива
int[] myArray = CreateRandomeArray(n, min, max);
ShowArray(myArray);

//кол-во четных чисел в массиве
int EvenNambers(int[] array)
{
    int count = 0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i] % 2==0)
        count ++;
    }
    return count;
}
Console.WriteLine(EvenNambers(myArray));
*/

/*
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (индексах).

int[] CreateRandomeArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; 
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
return array;
}

void ShowArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();    
}   

Console.WriteLine("Input a number of elemrnts: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());       
Console.WriteLine("Input a max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomeArray(n, min, max);
ShowArray(myArray);
//сумма элементов нечетных позиций
int Summe(int[] array)
{
    int sum = 0;
    for(int i=1; i<array.Length; i=i+2)
    {
        sum = sum + array[i];
    }
    return sum;
}
Console.WriteLine(Summe(myArray));
*/

/*
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

double[] CreateRandomeArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1); //замена целочисленных элементов на вещественные
        double num1 = new Random().NextDouble();
        double num2 = Math.Round(num1, 2);
        array[i] = array[i] + num2;
    }
return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();    
}   

Console.WriteLine("Input a number of elemrnts: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomeArray(n, min, max);
ShowArray(myArray);

//определение max min элементов массива, вычисление разницы между max и min 
void SubtractionMinMax(double[] array)
{
    int min = 0;
    int max = 0;
    int i = 0;

    for(i = 0; i < array.Length;)
    {
        if(array[i] < array[min]) min = i;
        if(array[i] > array[max]) max = i;
        i++;
    }
    double result = array[max] - array[min];
    Console.WriteLine($"min element: " + array[min]);
    Console.WriteLine($"max element: " + array[max]);
    Console.WriteLine($"subtraction max & min: " + result);
}
SubtractionMinMax(myArray);
*/