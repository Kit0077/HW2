Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberToString = Convert.ToString(number);
int lenght = numberToString.Length;

if (lenght > 2 && lenght < 4)
{
    int a = number / 10;
    int b = a % 10;
    Console.Write($"Вторая цифра числа {number} равна {b}");
}
else Console.Write("Число не трехзначное");