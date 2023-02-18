/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этот элемент или же указание, что такого элемента нет.
Например, задан массив: 3 4
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет */

void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 21); // [1, 20]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void PrintMatrix(int[, ] matrix)
{
    Console.WriteLine("Введите позицию элемента в cтроке массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите позицию элемента в столбце массива: ");        
    int colums = Convert.ToInt32(Console.ReadLine());
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            if (rows < matrix.GetLength(0) && colums < matrix.GetLength(1)) 
            {
                Console.WriteLine($"Такая позиция в массиве есть, её значение: {matrix[rows, colums]}");
                break;
            }
            else 
            {
                Console.WriteLine($"{rows}{colums} -> такой позиции в массиве нет");
                break;
            }
        }
        break;
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];

Console.WriteLine("Начальная матрица: ");
InputMatrix(matrix);
PrintMatrix(matrix);