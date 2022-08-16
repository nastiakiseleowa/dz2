while (true)
{
    Console.Write("Введи число: ");
    string Number = Convert.ToString(Convert.ToInt32(Console.ReadLine()));
    if (Number.Length > 2)
    {
        Console.WriteLine("Третья цифра: " + Number[2]);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}