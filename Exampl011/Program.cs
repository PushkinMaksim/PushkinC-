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
