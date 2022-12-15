// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine();
double[,] GetTableDouble(int m, int n)
{
double[,] table = new double[m, n];
for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().NextDouble()*100;
        
        }
    }
    return table;
    
}
void PrintTable(double[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            Console.Write("{0,6:F2}",   tab[i, j]);
        }
        Console.WriteLine();
    }
}
int m = 3;
int n = 4;
double[,] TableDouble = GetTableDouble(m,n);
PrintTable(TableDouble);



// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] CreateArray(int row, int col, int min, int max)
// {
//     int[,] array = new int[row, col];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }
// int[] FindNumberPosition(int[,] arr, int number)
// {
//     int[] position = new int[2];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (arr[i, j] == number)
//             {
//                 position[0] = i + 1;
//                 position[1] = j + 1;
//                 return position;
//             }
//         }
//     }
//     position[0] = -1;
//     position[1] = -1;
//     return position;
// }
// void PrintArray(int[,] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] / 1000 > 0) Console.Write($"{array[i, j]}   ");
//             else if (array[i, j] / 100 > 0) Console.Write($" {array[i, j]}   ");
//             else if (array[i, j] / 10 > 0) Console.Write($"  {array[i, j]}   ");
//             else Console.Write($"   {array[i, j]}   ");
//         }
//         Console.WriteLine();
//     }
// }
// void PrintPosition(int[] pos, int num)
// {
//     Console.WriteLine();
//     if (pos[0] > 0 && pos[1] > 0) Console.WriteLine($"Число {num} находится в {pos[0]}-й строке, {pos[1]}-м столбце");
//     else Console.WriteLine($"Число {num} отсутствует в заданном массиве");
//     Console.WriteLine();
// }
// int GetNumerToFind()
// {
//     Console.WriteLine();
//     Console.Write("Введите число:   ");
//     string writeNumber = Console.ReadLine();
//     int number = Convert.ToInt32(writeNumber);
//     return number;
// }
// int row = 4;
// int col = 4;
// int min = 1;
// int max = 100;

// int[,] array1 = CreateArray(row, col, min, max);
// PrintArray(array1);
// int number = GetNumerToFind();
// int[] position = FindNumberPosition(array1, number);
// PrintPosition(position, number);


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// int[,] GetMatrix(int row, int col, int min, int max)
// {
//     int[,] array = new int[row, col];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }
// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] >= 10) Console.Write($" {array[i, j]}   ");
//             else Console.Write($"   {array[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }
// double[] GetArithmeticMean(int[,] array)
// {
//     double[] result = new double[array.GetLength(1)];
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum += array[i, j];
//             result[j] = sum / array.GetLength(1);
//         }
//     }
//     return result;
// }
// void PrintArray(double[] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"  {array[i]} ");
//     }
// }
// int row = 4;
// int col = 4;
// int min = 1;
// int max = 10;

// int[,] matrix = GetMatrix(  row, col, min, max);
// PrintMatrix(matrix);
// double[] arithmeticMean = GetArithmeticMean(matrix);
// PrintArray(arithmeticMean);
// Console.WriteLine();
// Console.WriteLine();