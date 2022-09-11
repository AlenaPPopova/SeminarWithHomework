

//         *******ДЗ К 7 СЕМИНАРУ*******

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] CreateRandom2dArray(int m, int n){
//     double[,] array = new double[m, n];
//     for(int i = 0; i<m; i++){                              //Создание массива
//         for(int j = 0; j<n; j++){
//             array[i,j] = new Random().NextDouble()* 10;      
//         }
//     }     
//     return array;
// }

// void ShowMe2dArray(double[,] array){                      
//     for(int i = 0; i<array.GetLength(0); i++){        
//         for(int j = 0; j<array.GetLength(1); j++){    
//             Console.Write(Math.Round(array[i,j], 1) + " ");     //округляет до 1 цифры после запятой
//         }
//         Console.WriteLine();
//     }
// }

// double[,] array = CreateRandom2dArray(5,5);
// ShowMe2dArray(array);




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет
// 1,2 -> 2

// int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
//     int[,] array = new int[rows,cols];
//     for(int i = 0; i<rows; i++)                               //Создание массива
//         for(int j = 0; j<cols; j++)
//             array[i,j] = new Random().Next(min,max+1);          
//     return array;
// }







// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// void [,] CreateArrayDouble(int[,] array)
// {
//   for (int i = 0; i < m; i++)
//   {
//     for (int j = 0; j < n; j++)
//     {
//       array[i, j] = new Random().Next() * 20 - 10;
//     }
//   }
// }
// int[,] arrayWhole = new int[m, n];
// arrayWhole = TransformationArrayWhole(array);

// WriteArrayInt(arrayWhole);

// Console.Write($"\nCреднее арифметическое:\n");
// for (int i = 0; i < n; i++)
// {
//   double arithmeticMean = 0;
//   for (int j = 0; j < m; j++)
//   {
//     arithmeticMean += arrayWhole[j, i];
//   }
//   arithmeticMean = Math.Round(arithmeticMean / m, 1);
//   Console.WriteLine($"столбца № {i+1} {arithmeticMean}");
// }

// int[,] TransformationArrayWhole (double[,] array)
// {
//   int[,] arrayWhole = new int[array.GetLength(0), array.GetLength(1)];
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       arrayWhole[i, j] = Convert.ToInt32(array[i, j]);
//     }
//   }
//   return arrayWhole;
// }

// void WriteArrayInt (int[,] arrayWhole){
// for (int i = 0; i < m; i++)
//   {
//       for (int j = 0; j < n; j++)
//       {
//         Console.Write(arrayWhole[i, j] + " ");
//       }
//       Console.WriteLine();
//   }
// }


// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"m = {m}, n = {n}.");
// double[,] array = new double[m, n];
// CreateArrayDouble(array);
// Console.WriteLine();
// int[,] arrayWhole = new int[m, n];
// arrayWhole = TransformationArrayWhole(array);
// WriteArrayInt(arrayWhole);
// Console.Write($"\nCреднее арифметическое:\n");



