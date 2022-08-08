Console.Write("Введите число ");
string number = Console.ReadLine();
Console.Clear();
int number2 = Int32.Parse(number);

int count = 2;
if(number2 < 2) 
{
    Console.Write("Введите другое число");
}
else
{
    while(count <= number2)
    {
        Console.Write(count + " ");
        count = count + 2;
    }
}