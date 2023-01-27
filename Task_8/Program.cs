Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;

while (i < n)
{
    i += 2;
    Console.Write("{0} ",i);   
}

