Console.WriteLine("Данная программа создаёт двумерный массив, размер которого зависит от введёных пользователем - количества строк и столбцов, заполняется случайными целыми числами. И находит среднее арифметическое элементов в каждом столбце.");
Console.Write("Введите необходимое количество строк для создания двумерного массива: ");

int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите необходимое количество столбцов для создания двумерного массива: ");

int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[n, m];

FillArrayRandomNumbers(numbers);

Console.Write("Средние арифметические элементов в каждом столбце следующие: ");
for (int j = 0; j < numbers.GetLength(1); j++)
{
double avarage = 0;

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers [i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    Console.WriteLine("Создан следующий двумерный массив со случайными целыми числами: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
        Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


