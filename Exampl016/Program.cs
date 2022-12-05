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

Console.Write("Input a number of rows 1: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible 1: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible 1: ");
int max1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Input a number of rows 2: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible 2: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible 2: ");
int max2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] myArray = CreateRandom2dArray(m1, n1, min1, max1);
Show2dArray(myArray);
Console.WriteLine();

int[,] myArray1 = CreateRandom2dArray(m2, n2, min2, max2);
Show2dArray(myArray1);

int[,] Composition(int[,] arr1, int[,] arr2)
{
    if (arr1.GetLength(1) != arr2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] r = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                r[i,j] += arr1[i,k] * arr2[k,j];
            }
        }
    }
    return r;
}

void Show2dArrayComposition(int[,] arr1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            Console.Write("{0} ", arr1[i, j]);
        }
        Console.WriteLine();
    }
}
int[,] myArray2 = Composition(myArray, myArray1);
Console.WriteLine();
Show2dArrayComposition(myArray2);
*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[, ,] CreateRandom3dArray(int row, int col, int dep)
{
    int[, ,] array = new int[row, col, dep];
    int x = 9;
    if ((row * col * dep) > 90) throw new Exception("МАТРИЦУ СОЗДАТЬ НЕЛЬЗЯ");
    for(int i = 0; i < row; i++)       
        for(int j = 0; j < col; j++)
            for(int k = 0; k < dep; k++)
            {
                x = x + 1;
                array[i, j, k] = x;
            }

    return array;
}

void Show3dArray(int[, ,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("|");
            for(int k =0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k], 1} ({i}, {j}, {k}) |");
            Console.WriteLine();
        }
}

Console.Write("Input a number of row: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of col: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of dep: ");
int p = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input a min possible: ");
//int min = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input a max possible: ");
//int max = Convert.ToInt32(Console.ReadLine());

int[, ,] myArray = CreateRandom3dArray(m, n, p);
Console.WriteLine();
Show3dArray(myArray);
*/


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)         
    {
        for(int j = 0; j < columns; j++)  
        {
            array[i, j] = 10 + (i * columns) + j;
        }
    }
    return array;
}

int[,] Spiral(int[,] array)
{
    int[,] array1 = new int[array.GetLength(0), array.GetLength(1)];
    for(int current = 1, p = 0; p < array.GetLength(1)/2; p++)
    {
        for(int j = p; j < array.GetLength(1) - p; j++)
            array1[p, j] = current;
        for(int j = p; j < array.GetLength(1)-p; j++)
            array1[array.GetLength(1)-p-1, j] = current;
        for(int i = p + 2; i < array.GetLength(0) - p - 1; i++)
            array1[i, p] = current;
        for(int i = p + 1; i < array.GetLength(0) - p - 1; i++)
            array1[i, array.GetLength(0) - p - 1] = current;
        current = 1 - current;
        array1[p + 1, p] = current;
    }
    if(array.GetLength(0) % 2 != 0 && array1[0, 0] == 1)
        array1[array.GetLength(1)/2, array.GetLength(2)/2] = 1;
    return array1;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");
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
Console.WriteLine();
int[,] myArray1 = Spiral(myArray);
Show2dArray(myArray1);
