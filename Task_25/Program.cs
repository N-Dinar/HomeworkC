/*  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), result = 1;
Console.Write("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < degree; i++)
    result = result * n;
Console.WriteLine($"{n} в {degree} степени = {result}");