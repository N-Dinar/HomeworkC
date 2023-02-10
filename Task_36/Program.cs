/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Clear();
Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 101); 
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i%2 != 0)
    sum += array[i];
}
Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях: {sum}");