//ДЗ к семинару 8
//Урок 8. Как не нужно писать код. Часть 2
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)         //переход по строкам
    {
        for(int j = 0; j < columns; j++)  //переход по столбцам
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
            Console.Write("0" + array[i, j] + "  ");
        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Console.WriteLine();
Show2dArray(myArray);

void SelectionSort(int[,] array)
{
    for(int k = 0; k < array.GetLength(0); k++)
        for (int i = 0; i < array.GetLength(1)-1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            if(array[k, j] > array[k, maxPosition]) maxPosition = j; 
        }

        int temporary = array[k, i];
        array[k, i] = array[k, maxPosition];
        array[k, maxPosition] = temporary;
    }
}
SelectionSort(myArray);
Console.WriteLine();
Show2dArray(myArray);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)         //переход по строкам
    {
        for(int j = 0; j < columns; j++)  //переход по столбцам
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
            Console.Write("0" + array[i, j] + "  ");
        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Console.WriteLine();
Show2dArray(myArray);

int[,] MinSum(int[,] array)
{
    int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];
    int minSum = newArray[0, 0];
    int sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                sum = sum + array[i, j];
                newArray[i, 0] = sum;
            }
            Console.WriteLine("Сумма в строке "+ (i+1) + ": " + newArray[i, 0] + " ");
            sum = 0;
            for(int j = 0; j < newArray.GetLength(1); j++)
                if(newArray[i, 0] < newArray[0, 0]) minSum = newArray[i, 0];
        }
        Console.WriteLine("Минимальная сумма: " + minSum);
    return newArray;       
}

Console.WriteLine();
MinSum(myArray);
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)         //переход по строкам
    {
        for(int j = 0; j < columns; j++)  //переход по столбцам
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
            Console.Write("0" + array[i, j] + "  ");
        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
Console.WriteLine();
int[,] myArray1 = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray1);




//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)         
    {
        for(int j = 0; j < columns; j++)  
        {
            array[i, j] = (i * columns) + j;
        }
    }
    return array;
}
*/
