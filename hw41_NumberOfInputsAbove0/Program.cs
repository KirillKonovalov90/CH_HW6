            // Программа принимает M чисел, введённых с клавиатуры и выводит
            // количество введённых чисел > 0

void NumbersInput (int M)
{
    int positives = 0;
    int[] array = new int[M];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        array[i] = int.Parse(Console.ReadLine()!);
        if (array[i] > 0) positives++;  
    }

    Console.WriteLine("Среди введённых чисел [" + string.Join(", ", array) + 
    "] имеется " + positives + " положительных");
}

int numM;

Console.Write("Введите желаемое количество вводимых чисел: ");
numM = int.Parse(Console.ReadLine()!);

NumbersInput(numM);