// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

// //1) Получение данных от пользователя
int n = InputNum("Количество строк матрицы: ");
int m = InputNum("Количество столбцов матрицы: ");

double[,] numbers = new double[n, m];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

//Печатаем двумерный массив
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод для заполнения двумерного массива
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

//метод для печати двумерного массива
void PrintArray(double[,] array)
{
    int i = 0; int j = 0;

    while (i < array.GetLength(0))
    {
        j = 0;
        while (j < array.GetLength(1))
        {
            Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0,16));
            //col[new System.Random().Next(0,16)]; 
            Console.Write(array[i, j] + "    ");
            Console.ResetColor(); 
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

