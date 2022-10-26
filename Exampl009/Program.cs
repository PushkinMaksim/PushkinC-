/*
void Metod1()
{
    Console.WriteLine("Автор...");
}
Metod1();
*/
/*
void Metod2(string msg)
{
    Console.WriteLine(msg);
}
Metod2("Текст сообщения");
*/
/*
void Metod21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Metod21("Текст", 4);
*/
/*
int Metod3()
{
    return DateTime.Now.Year;
}
int year = Metod3();
Console.WriteLine(year);
*/
/*
string Metod4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Metod4(10, "z");
Console.WriteLine(res);
*/
/*
string Metod4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Metod4(10, "z");
Console.WriteLine(res);
*/
/*
for(int i = 2; i<=10; i++)
{
    for(int j = 2; j<=10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
*/
string text = "- Я думаю, сказал князь, улыбаясь, - что,";
//"ежели бы вас послали вместо нашего милого Винцергероде"
//"вы бы взяли приступом согласие прусского короля";

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text Length;
    for(int i=0; i<length; i++)
    {
        if(text[i]==oldValue)
            result + $"{newValue}";
        else 
            result + $"{text[i]}";
    }
    return result;
}
string newText = Replase(text, " ", "|");
Console.WriteLine(newText);