Console.Write("Введите число ");
string number = Console.ReadLine();
Console.Clear();
double number2 = Convert.ToDouble(number);
double what = number2 % 2;
if(what == 0)
{
    Console.Write("Число " + number2 + " четное");
}
else
{
    Console.Write("Число " + number2 + " нечетное");
}
