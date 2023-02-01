//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//пользователь вводит размер массива
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
Gen1DArray(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
int sum = 0;

for (int a = 0; a < numbers.Length; a+=2)
    sum = sum + numbers[a];

    Console.WriteLine($"всего чисел:  {numbers.Length}, сумма элементов на нечётных позициях: {sum}");

//метод заполняет массив
void Gen1DArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,100);
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