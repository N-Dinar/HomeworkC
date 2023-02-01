Console.Clear();
Console.WriteLine("1-Понедельник, 2-Вторник, 3-Среда, 4-Четверг, 5-Пятница, 6-Суббота, 7-Воскресенье ");
Console.Write("Введите число соответствующий дню недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n > 0 && n < 8)
{
    if (n < 6) Console.Write("Рабочий день!");
    if (n > 5) Console.Write("Выходной!");
}
else 
Console.Write("Неправильный ввод!");