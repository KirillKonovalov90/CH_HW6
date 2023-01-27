            // Программа принимает параметрические коэффициенты k1, b1, k2, b2 прямых A и B
            // выводит координаты точки пересечения прямых М, если таковая имеется

void PointOfIntersectionCoordinates(double[] lineA, double[] lineB)
{
    double k1 = lineA[0], b1 = lineA[1], k2 = lineB[0], b2 = lineB[1], x, y;
    
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают и имеют бесконечное множество точек пересечения");
    }

    else if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны и следовательно не имеют точки пересечения");        
    }

    else
    {
        x = (b1 - b2) / (k2 - k1);
        y = k2 * x + b2;
        Console.WriteLine($"Точка пересечения M, прямых A и B, имеет координаты ({Math.Round(x, 2)}, {Math.Round(y, 2)})");
    }

}

double[] lineACoef, lineBCoef;

Console.Write("Введите коэффициенты k1 и b1 прямой A через пробел: ");
lineACoef = Console.ReadLine()!.Split(" ").Select(double.Parse).ToArray();

Console.Write("Введите коэффициенты k2 и b2 прямой B через пробел: ");
lineBCoef = Console.ReadLine()!.Split(" ").Select(double.Parse).ToArray();

PointOfIntersectionCoordinates(lineACoef, lineBCoef);