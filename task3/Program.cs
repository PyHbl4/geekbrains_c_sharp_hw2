Console.WriteLine("Какой порядковый день у сегодняшнего дня недели?");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber == 6 ^ dayNumber == 7)
{
    Console.WriteLine("Поздравляю, сегодня выходной!");
}
else
{
    Console.WriteLine("Увы, сегодня рабочий день...");
}