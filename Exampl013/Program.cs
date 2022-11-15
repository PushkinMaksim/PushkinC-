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

void ReverceArray(int[] array) // реверс массива
{
    for(int i = 0; i < array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = temp;
    }
}

// или
void ReverceArrayT(int[] array) // реверс массива
{
    for(int i = 0, j = array.Length -1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
ReverceArrayT(myArray);
ShowArray(myArray);

