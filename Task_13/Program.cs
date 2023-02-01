Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = n;
if (n > 99)
{
while (a > 999)
{
    a = a / 10;
}
    int a1 = a % 10;
    Console.Write(a1);
}
else Console.Write("Третьей цифры нет ");