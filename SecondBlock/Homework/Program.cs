// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трёхзначное число: ");
// int number = int.Parse(Console.ReadLine()!);
// if (number < 1000 && number > 99)
// {
//     Console.Write(number % 100 / 10);
// }
// else if (number < -99 && number > -1000)
// {
//     Console.Write(-number % 100 / 10);
// }
// else
// {
//     Console.Write("Error! Число не трёхзначное");
// }



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Отрицательные числа должны нормально работать
// -645 -> 5
// 645 -> 5
// 78 -> третьей цифры нет
// 3261279 -> 6

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// if (number < 0) number *= -1;
// if (number < 100 && number > -100)
// {
//     Console.Write("Третьей цифры нет");
// }
// else
// {
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     Console.Write(number % 10);
// }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Понедельник - 1");
// Console.WriteLine("Вторник - 2");
// Console.WriteLine("Среда - 3");
// Console.WriteLine("Четверг - 4");
// Console.WriteLine("Пятница - 5");
// Console.WriteLine("Суббота - 6");
// Console.WriteLine("Воскресенье - 7");
// Console.Write("День недели: ");
// int number = int.Parse(Console.ReadLine()!);
// if (number < 6 && number > 0)
// {
//     Console.Write("Будний день");
// }
// else if (number == 6 || number == 7)
// {
//     Console.Write("Выходной день");
// }
// else
// {
//     Console.Write("Error!");
// }