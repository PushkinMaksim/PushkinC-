//Урок 9. Как не нужно писать код. Часть 3
/*
//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
//промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowNumbers(int n)
{
    Console.Write(n +" ");
    if(n > 1) ShowNumbers(n - 1);
}
ShowNumbers(5);
*/

/*
//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

int Sum(int m, int n)
{
    if(n > m) 
    {
        return Sum(m, (n - 1)) + n;
        return m;
    }
    else 
        {
            if(n < m) return Sum(m, (n + 1)) + n;
            return m;
        }
}
Console.WriteLine(Sum(5, 1));
*/

/*
//Задача 68: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.
int Akk(int n, int m)
{
    if(n == 0) return m + 1;
    else
    {
        if((n!=0) && (m == 0))
            return Akk(n - 1, 1);
    
        else
            return Akk(n-1, Akk(n, m - 1));
    }
}
Console.WriteLine(Akk(3, 2));
*/