Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7) Console.Write("Это выходной день");
if (number != 6 && number != 7) Console.Write("Это не выходной день");