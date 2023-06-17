Console.Write("Введите число до 100000: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number;
string numberToString = Convert.ToString(number);
int lenght = numberToString.Length;
int[] array = new int[lenght];
int CountLenght = lenght - 1;
int count = 0;

if (lenght > 2 )
{
    if (number1 < 100000)
    {
        while (count < CountLenght)
        {
            array[lenght -1] = number % 10;
            count++;
            lenght = lenght -1;
            number = number / 10;
        }
    Console.Write($"Третья цифра чила {number1} равна {array[2]}");
    }
    else Console.Write("Введеное значение превышает 100000");
    
}
else Console.Write("В вашем числе нет третьей цифры");
Console.WriteLine();
