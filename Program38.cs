// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//Console.Clear();
int size;
Console.Write("Введите размер массива (N): ");
size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
Console.Write("[ ");
ArrayRandomNumbers(numbers);
int min=numbers[0];
int max=numbers[0];
Console.Write("]");

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
Console.WriteLine($" -> {max-min}");


void ArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,10);
        Console.Write(array[i] + "; ");
    }
}