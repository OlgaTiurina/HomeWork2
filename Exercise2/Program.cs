// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(anyNumber);

if (stringNumber.Length > 2)
{
    Console.WriteLine("Третья цифра данного числа -> " + stringNumber[2]);
}
else
{
    Console.WriteLine("Третья цифра отсутствует");
}
