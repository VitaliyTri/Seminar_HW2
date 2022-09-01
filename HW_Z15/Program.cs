// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Введите число от одного до семи: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7)
{
    Console.WriteLine("Да! Это - Выходной!!!");
}

else
{
    Console.WriteLine("Рабочий день...");
}

