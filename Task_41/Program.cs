Console.Clear();
Console.Write("Введите количество чисел: ");
    int count = int.Parse(Console.ReadLine()!);
    int positiveCount = 0;
    for (int i = 0; i < count; i++) {
        Console.Write($"Введите число {i + 1}: ");
        int number = int.Parse(Console.ReadLine()!);
        if (number > 0) {
            positiveCount++;
        }
    }

Console.WriteLine($"Количество положительных чисел: {positiveCount}");