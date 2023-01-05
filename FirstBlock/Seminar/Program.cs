// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя)
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// string input = Console.ReadLine()!;
// int parsedInput = int.Parse(input);
// int result = parsedInput * parsedInput;
// Console.Write(result);

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// Console.Write($"Результат: {number * number}");



// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a == b * b)
// {
//     Console.Write("Да");
// }
// else
// {
//     Console.Write("Нет");
// }



// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру
// 3 -> Среда
// 5 -> Пятница

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// if (number == 1)
// {
//     Console.Write("Понедельник");
// }
// else if (number == 2)
// {
//     Console.Write("Вторник");
// }
// else if (number == 3)
// {
//     Console.Write("Среда");
// }
// else if (number == 4)
// {
//     Console.Write("Четверг");
// }
// else if (number == 5)
// {
//     Console.Write("Пятница");
// }
// else if (number == 6)
// {
//     Console.Write("Суббота");
// }
// else if (number == 7)
// {
//     Console.Write("Воскресенье");
// }
// else
// {
//     Console.Write("Введите число от 1 до 7 включительно");
// }



// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N
// 4 -> -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 -> -2, -1, 0, 1, 2

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// for (int i = -number; i < number; i++)
// {
//     Console.Write($"{i}, ");
// }
// Console.Write(number);



// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа
// 456 -> 6
// 782 -> 2
// 918 -> 8

// Console.Write("Введите трёхзначное число: ");
// int number = int.Parse(Console.ReadLine()!);
// Console.Write($"Последнее число - {number % 10}");