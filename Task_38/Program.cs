/*  Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3, 7, 22, 2, 78] -> 76 */

Console.Clear();
Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 101); 
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
int max = array[0], min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[(int)i]>max) 
    max = array[(int)i];
    if (array[(int)i]<min) 
    min = array[(int)i];
}
Console.WriteLine($"Максимальный элемент в массиве: {max}");
Console.WriteLine($"Минимальный элемент в массиве: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами: {max-min}");