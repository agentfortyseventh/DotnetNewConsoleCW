// Console.Write("Введите имя пользователя: ");
// string userName = Console.ReadLine()!;
// Console.Write($"Привет, {userName}!");



// int a = 3;
// int b = 5;
// Console.Write($"Результат: {a + b}");



// int a = 3;
// int b = 5;
// int result = a + b;
// Console.Write($"Результат: {result}");



// int a = 10;
// int b = 5;
// int result = a / b;
// Console.Write($"Результат: {result}");



// int a = 12;
// int b = 5;
// int result = a / b;
// Console.Write($"Результат: {result}"); // Целые числа



// double a = 12;
// double b = 5;
// double result = a / b;
// Console.Write($"Результат: {result}"); // Вещественные числа



// int a = new Random().Next(1, 10);
// int b = new Random().Next(1, 10);
// int result = a + b;
// Console.Write($"{a} + {b} = {result}");



// Console.Write("Введите имя пользователя: ");
// string userName = Console.ReadLine()!;
// if (userName == "Маша")
// {
//     Console.Write("Ура, это же Маша!");
// }
// else
// {
//     Console.Write($"Привет, {userName}!");
// }



// Console.Write("Введите имя пользователя: ");
// string userName = Console.ReadLine()!;
// if (userName.ToLower() == "маша")
// {
//     Console.Write("Ура, это же Маша!");
// }
// else
// {
//     Console.Write($"Привет, {userName}!");
// }



// int a = 1;
// int b = 2;
// int c = 6;
// int d = 8;
// int e = 4;
// int max = a;
// if (a > max) max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// if (d > max) max = d;
// if (e > max) max = e;
// Console.Write($"Результат: {max}");



// int xa = 15, ya = 1,
//     xb = 1, yb = 10,
//     xc = 30, yc = 10;
// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("+");
// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("+");
// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("+");
// int x = xa, y = xb;
// int count = 0;
// while (count < 1000)
// {
//     int number = new Random().Next(0, 3); // 0, 1, 2
//     if (number == 0)
//     {
//         x = (x + xa) / 2;
//         y = (y + ya) / 2;
//     }
//     if (number == 1)
//     {
//         x = (x + xb) / 2;
//         y = (y + yb) / 2;
//     }
//     if (number == 2)
//     {
//         x = (x + xc) / 2;
//         y = (y + yc) / 2;
//     }
//     Console.SetCursorPosition(x, y);
//     Console.WriteLine("+");
//     count++;
// }