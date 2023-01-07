// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
// int firstDigit = number / 100;
// int secondDigit = number % 10;
// int result = firstDigit * 10 + secondDigit;
// Console.Write(result);



// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число N2 не кратно числу N1, то программа выводит остаток от деления
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.Write("Первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a < b)
// {
//     Console.Write("Error! Проверяемое число не может быть меньше");
// }
// else if (a - b * (a / b) == 0)
// {
//     Console.Write("Кратно");
// }
// else
// {
//     Console.Write($"Не кратно, остаток {a - b * (a / b)}");
// }



// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

// Console.Write("Первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a == b * b || b == a * a)
// {
//     Console.Write("Да");
// }
// else
// {
//     Console.Write("Нет");
// }