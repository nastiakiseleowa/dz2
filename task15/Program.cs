while (true)
{
    Console.Write("Введите день недели: ");
    int day = Convert.ToInt32(Console.ReadLine());
    if (day < 6)
        Console.WriteLine("нет");
    else if (day == 6 | day == 7)
        Console.WriteLine("да");
}