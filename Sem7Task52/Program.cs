// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

// //1) Получение данных от пользователя
int n = InputNum("Количество строк матрицы: ");
int m = InputNum("Количество столбцов матрицы: ");

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);


//Печатаем двумерный массив
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
for (int j = 0; j < numbers.GetLength(1); j++)

//находим ср арифметич
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);

// метод для заполнения двумерного массива
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

//метод для печати двумерного массива
void PrintArray(int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write(" ");
        Console.WriteLine("");
    }
}