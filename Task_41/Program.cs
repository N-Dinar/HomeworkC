/*  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.Clear();
Console.WriteLine("Введите количество элемментов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите массив: ");
int[] array = new int[n];
    for (int i = 0; i < n; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"[{string.Join(", ", array)}]");
int count = 0;   
    for (int i = 0; i < n; i++)
    {    
        if(array[i] > 0)
        count++;
    }
Console.WriteLine($"Количество положительных элементов:{count}");