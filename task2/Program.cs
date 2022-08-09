Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if ((number / 100) < 1)
{
    Console.WriteLine("Третья цифра в числе отсутствует");
}
else
{
    char numberString = number.ToString()[2];
    Console.WriteLine("Третья цифра в числе: " + numberString);
}