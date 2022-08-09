internal class Program
{
    private static void Main(string[] args)
    {
        //Есть прога с бесконечным циклом. Когда пользователь вводит exit, прога заканчивается
        Console.Clear();
        string password = "exit";
        Console.Write(" Введите кодовое слово ");
        string answer = Console.ReadLine();
        int count = 1;
        bool eq = answer.ToLower() == password;
        while (!eq)
        {
            Console.Write("Снова введите кодовое слово ");
            Console.Clear();//как сделать так, чтобы прога бесконечно предлагала вводить пароль, а не зацикливалась выводя и тут же стирая "Введите кодовое слово"
            count++;
        }

        Console.Clear();
        Console.Write("Поздравляем, вы покинули колесо сансары!");
    }
}