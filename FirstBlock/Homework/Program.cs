// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a < b)
// {
//     Console.Write($"Результат: {b} > {a}");
// }
// else
// {
//     Console.Write($"Результат: {a} > {b}");
// }



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите третье число: ");
// int c = int.Parse(Console.ReadLine()!);
// if (a > b && a > c)
// {
//     Console.Write($"Максимальное число: {a}");
// }
// else if (b > a && b > c)
// {
//     Console.Write($"Максимальное число: {b}");
// }
// else
// {
//     Console.Write($"Максимальное число: {c}");
// }



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// if (number % 2 == 0)
// {
//     Console.Write("Чётное");
// }
// else
// {
//     Console.Write("Нечётное");
// }



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// for (int i = 2; i < number; i += 2)
// {
//     Console.Write(i + ", ");
// }
// Console.Write(number);