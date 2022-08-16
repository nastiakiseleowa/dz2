while (true)
{
    Console.Write("Введите трехзначное число: ");
    string Number = Convert.ToString(Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine("Вторая цифра: " + Number[1]);
}