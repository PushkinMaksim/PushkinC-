/*//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int current = 2;
while (current <= n)
{
    Console.Write(current + ", ");
    current = current + 2;    
}
*/




void ProgressStep(int num)
{
for(int i = 0; i<num;)
{
    i++;
    Console.Write($"{i} ");
}
}

Console.WriteLine("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
ProgressStep(n);





