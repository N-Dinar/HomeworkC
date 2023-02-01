Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n>999 || n<100)
Console.WriteLine("Это не трехзначное число ");
else
Console.WriteLine(n / 10 % 10);