// Задача 38: Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1
// double[] FillArrayWithRandomNumber(double size)
// {
// double[] arr = new double[size];
// Random rnd = new Random();
// for (int i = 0; i < arr.Length; i++)
// {
// arr[i] = rnd.Next(-10, 10);
// }
// return arr;
// }

// System.Console.Write("Введите размер массива: ");
// double length = Convert.ToInt32(Console.ReadLine());
// double[] array = FillArrayWithRandomNumber(length);
// System.Console.WriteLine(string.Join(", ", array));



Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}


Console.WriteLine($"Разница  = {max - min}");
void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ; ");
        }
    Console.Write("]");
    Console.WriteLine();
}