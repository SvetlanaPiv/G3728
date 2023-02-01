// Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

//пользователь вводит размер массива
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
Gen1DArray(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
int count = 0;
int notcount = 0;


// находим четные
for (int a = 0; a < numbers.Length; a++)
if (numbers[a] % 2 == 0)
count++;

//находим нечетные
for (int a = 0; a < numbers.Length; a++)
if (numbers[a] % 2 != 0)
notcount++;


Console.WriteLine($"массив из {numbers.Length} чисел, четных: {count}");
Console.WriteLine($"массив из {numbers.Length} чисел, нечетных: {notcount}");

// метод создает массив
void Gen1DArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,999);
    }
}

// метод выводит массив
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

