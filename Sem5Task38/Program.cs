// Задайте массив вещественных чисел. Найдите разницу между максимальным и
//минимальным элементов массива.

//пользователь вводит размер массива
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
Gen1DArray(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
double min = int.MaxValue;
double max = int.MinValue;
// находим макс и миним занчения
for (int a = 0; a < numbers.Length; a++)
{
    if (numbers[a] > max)
        {
            max = numbers[a];
        }
    if (numbers[a] < min)
        {
            min = numbers[a];
        }
}

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

//метод заполняет массив
void Gen1DArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
// метод выводит массив на экран
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + "   ");
        }
    Console.Write("]");
    Console.WriteLine();
}