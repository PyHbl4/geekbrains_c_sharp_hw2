Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int num = number / 10;
int result = num - ((num / 10) * 10);
Console.WriteLine("Вторая цифра цисла - " + result);
