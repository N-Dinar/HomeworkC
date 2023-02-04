/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 10000 || n > 99999)
{
    Console.Write("Вы ошиблись!\nВведите пятизначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int n1 = n / 10000; 
int n4 = n /10 % 10; 
int n3 = n / 100 % 10; 
int n2 = n /1000 % 10; 
int n5 = n % 10;
if (n5 == n1 && n4 == n2) 
Console.WriteLine("Число палиндромное");
else 
Console.WriteLine("Число не палиндромное");