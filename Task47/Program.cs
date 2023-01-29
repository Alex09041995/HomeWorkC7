Console.WriteLine("Данная программа создаёт двумерный массив, размер которого зависит от введёных пользователем - количества строк и столбцов, и заполняется случайными вещественными числами.");
Console.Write("Введите необходимое количество строк для создания двумерного массива: ");

int linesVol = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите необходимое количество столбцов для создания двумерного массива: ");

int columnsVol = Convert.ToInt32(Console.ReadLine());
double [,] numbers = new double [linesVol, columnsVol];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double [,] array)
{
    Console.WriteLine("Создан следующий двумерный массив со случайными вещественными числами: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}




