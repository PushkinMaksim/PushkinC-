//ДЗ к семинару 8
//Урок 8. Как не нужно писать код. Часть 2
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
            Console.Write("0" + array[i, j] + " (" +i + " " + j + ") " + "   ");
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

void ReSortRows(int[,] array)
{
    int maxPosi = 0;
    int maxPosj = 0;
    int maxx = array[maxPosi, maxPosj];
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1) - 1; j++)
            for(int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i, j] > array[maxPosi, maxPosj]) maxx = array[i, j];
                {
                    maxPosi = i;
                    maxPosj = k;

                    int temp = array[i, j];
                    array[i, j] = array[maxPosi, maxPosj];
                    array[maxPosi, maxPosj] = temp;
                }
            }
}           
ReSortRows(myArray);
Console.WriteLine();
Show2dArray(myArray);


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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