
//Zadacha41();
void Zadacha41()
{
    Console.WriteLine("Сколько чисел требуется ввести:");
    int num = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите {i + 1} число ");
        int enterNum = Convert.ToInt32(Console.ReadLine());
        if (enterNum > 0) count++;
    }
    Console.WriteLine(" " + count);
}

Zadacha43();
void Zadacha43()
{
    Console.WriteLine("Введите  значение координаты k1 для прямой А:");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите  значение координаты b1 для прямой А:");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите  значение координаты k2 для прямой B:");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите  значение координаты b2 для прямой B:");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"A({k1},{b1})");
    Console.WriteLine($"B({k2},{b2})");
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
Console.WriteLine($" Точка пересечения ({x}, {y}) ");

}