﻿Console.Write("Введите первое число ");
string number1 = Console.ReadLine();
Console.Clear();
Console.Write("Введите второе число ");
string number2 = Console.ReadLine();
Console.Clear();
int one = Int32.Parse(number1);
int two = Int32.Parse(number2);
if(one > two) Console.Write("Максимальное число " + one);
if(two > one) Console.Write("Максимальное число " + two);
if(two == one) Console.Write("Оба числа равны " + two);
