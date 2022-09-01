// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.



Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
if (number.Length > 2)
{
    Console.WriteLine(number[2]);
}
else Console.WriteLine($"В числе {number} отсутствует третья цифра");