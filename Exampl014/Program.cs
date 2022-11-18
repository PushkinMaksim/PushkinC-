/*
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

int Kolich(int a)
{
    int count = 0;
    for(int i = 0; i < a; i++)
    {
        Console.Write("Input num: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > 0)
        count++;
    }
 Console.WriteLine();   
 return count;   
}

Console.WriteLine("Input M : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"result a number > 0 is {Kolich (m)}");
*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


/*void InterectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1*x + b1;
    Console.WriteLine(x + ", " + y);
} 

Console.Write("Input k1 : ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2 : ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b1 : ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2 : ");
double b2 = Convert.ToDouble(Console.ReadLine());
InterectionPoint(b1, k1, b2, k2);
*/
