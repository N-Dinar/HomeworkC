Console.Clear();
Console.Write("Введите количество дней: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 32); 
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
int count = 0;
int b = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    count++;
    if(array[i] % 2 == 1)
    b++;
}
if(count > b)
Console.WriteLine("Васе выходит 4!");
else
Console.WriteLine("Васе выходит 3!");