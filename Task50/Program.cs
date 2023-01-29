Console.WriteLine("Данная программа принимает указанную позицию элемента в двумерном массиве - размером: 5 строк, 7 столбцов со случайно созданными значениями, и возвращает значение этого элемента или же указывает, если данного элемента нет.");
Console.Write("Введите номер строки двумерного массива от 1 до 5: ");

int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца двумерного массива от 1 до 7: ");

int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [5, 7];

FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
Console.WriteLine("Данного элемента в двумерном массиве не существует!");
}
else
    {
    Console.WriteLine($"Значение введённого элемента строки под номером: {n}, и столбца под номером: {m}, равняется: {numbers[n - 1, m - 1]}");
    }

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i, j] = new Random().Next(-100, 100) / 10;
            }   
        }
}

void PrintArray(int [,] array)
{
    Console.WriteLine("Созданный программой двумерный массив со случайными значениями - размером: 5 строк, 7 столбцов: ");
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