// Требуется вычислить, сколько раз встречается некоторое число X в массиве A[1..N].

Console.Clear();
Console.Write("Введите количество элемментов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите массив: ");
int[] array = new int[n];
for (int i = 0; i < n; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.Write("Введите число X: ");
int x = Convert.ToInt32(Console.ReadLine()), b = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i] == x)
    b++;
Console.WriteLine($"Число {x} в массиве встречается {b} раз");