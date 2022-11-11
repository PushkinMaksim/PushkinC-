//Урок 5. Функции продолжение

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
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

//Запуск метода генерации и вывода элементов массива
int[] myArray = CreateRandomeArray(n, min, max);
ShowArray(myArray);

/*
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
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (индексах).
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

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
