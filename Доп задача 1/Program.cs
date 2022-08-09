// В переменной стринг есть секретное сообщение, во второй пароль. Пользователю проги дается 3 попытки ввести пароль и увидеть секретное сообщение.
string secret = "Земля плоская и управляется разумными рептилоидами";
string password = "сорок два";
Console.Write(" Введите пароль ");
int count = 1;
while(count<=3) 
{
    
string answer = Console.ReadLine();
Console.Clear();
bool eq = answer.ToLower() == password;
  if(eq) 
 {
    Console.Write(secret); // Как прервать цикл здесь, чтобы программа больше не давала возможность вводить пароль?
                           //при использовании break прерывается цикл while 
 }
  else
 {
    Console.Write("Неверный ответ, у вас осталось всего " + (3 - count) + " попытки. Введите пароль ");
    count++;
 }
}
Console.Clear();
Console.Write("Превышено число попыток. Не видать вам секрета!");

/*if(count>3)
{
    Console.Write("Превышено число попыток. Не видать вам секрета!");
}
else
{
    if(eq)
    {
        Console.Write(secret); 
    }
   else
   {
    Console.Write("Неверный ответ, у вас осталось всего " + (3 - count) + " попытки. Введите пароль ");
    
    }
    count++;
}
*/
   
