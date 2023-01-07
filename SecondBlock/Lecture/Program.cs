// int a1 = 19;
// int b1 = 28;
// int c1 = 37;
// int a2 = 46;
// int b2 = 55;
// int c2 = 64;
// int a3 = 73;
// int b3 = 82;
// int c3 = 91;
// int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;
// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;
// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;
// Console.Write(max);



// int a1 = 19;
// int b1 = 28;
// int c1 = 37;
// int a2 = 46;
// int b2 = 55;
// int c2 = 64;
// int a3 = 73;
// int b3 = 82;
// int c3 = 91;
// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// Console.Write(max);



// int a1 = 19;
// int b1 = 28;
// int c1 = 37;
// int a2 = 46;
// int b2 = 55;
// int c2 = 64;
// int a3 = 73;
// int b3 = 82;
// int c3 = 91;
// int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// Console.Write(max);



// int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
// int n = array.Length;
// int find = 5;
// int index = 0;
// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.Write(index);
//     }
//     index++;
// }



// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);
// void FillArray(int[] collection)
// {
//     int lenght = collection.Length;
//     int index = 0;
//     while (index < lenght)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }
// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     Console.Write("[ ");
//     while (position < count - 1)
//     {
//         Console.Write(col[position] + ", ");
//         position++;
//     }
//     Console.Write(col[position]);
//     Console.Write(" ]");
// }



// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// int pos = IndexOf(array, 4);
// Console.Write("Позиция: " + pos);
// int IndexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = -1;
//     while (index < count)
//     {
//         if (collection[index] == find)
//         {
//             position = index;
//             break;
//         }
//         index++;
//     }
//     return position;
// }
// void FillArray(int[] collection)
// {
//     int lenght = collection.Length;
//     int index = 0;
//     while (index < lenght)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }
// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     Console.Write("[ ");
//     while (position < count - 1)
//     {
//         Console.Write(col[position] + ", ");
//         position++;
//     }
//     Console.Write(col[position]);
//     Console.Write(" ]");
// }