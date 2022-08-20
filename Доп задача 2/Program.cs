internal class Program
{
    private static void Main(string[] args)
    {
        //Есть прога с бесконечным циклом. Когда пользователь вводит exit, прога заканчивается
Console.Write("Введите пароль: ");
string password = Console.ReadLine();
Console.Clear();
int i = 0;
 while (password != "exit") 
 {
    Console.WriteLine("Попытка "+ (i+1));
    i++;
    Console.Write("Введите ВЕРНЫЙ пароль, чтобы прекратить: ");
    password = Console.ReadLine();
    Console.Clear();
}
Console.Write("Поздравляем, вы покинули колесо сансары!");

    }
}
