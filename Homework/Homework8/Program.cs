// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] CreateArray2d = {{1, 4, 7, 2, 8},
//                         {5, 9, 2, 3, 4},
//                         {8, 4, 2, 4, 1},
//                         {5, 1, 8, 7, 3},
// }

// int[,] DescingOrderArray(int[,] array){                         
//     int tmp = 0;
//     for(int a = 0; a < 5; a++){
//         for(int b = 0; b < 4; b++){
//             for(int i = 0; i < array.GetLength(0); i++)
//                 for(int j = 0; j < array.GetLength(1) - 1; j++){
//                     if(array[i,j] < array[i, j + 1]){
//                         tmp = array[i, j + 1];
//                         array[i, j + 1] = array[i, j];
//                         array[i, j] = tmp;
//                     }
//                 }
//         }
//     }
//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Show2dArray(CreateArray2d);
// int[,] ArraySort = DescingOrderArray(CreateArray2d);
// Console.WriteLine();
// Show2dArray(ArraySort);



// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с
// наименьшей суммой элементов: 1 строка


// int[,] CreateArray2d = {{1, 4, 7, 2, 8},
//                         {5, 9, 2, 3, 4},
//                         {8, 4, 2, 4, 1},
//                         {5, 1, 8, 7, 3},
// };

// int MinRowArray(int[,] array){
//     int result = 0;
//     int row = 0;
//     int temp = 0;
//     for(int j = 0; j < array.GetLength(1); j++){    
//         result += array[0,j];
//     }
//     for(int i = 1; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             temp += array[i,j];
//         }
//         if(temp < result){                           
//             result = temp;
//             row = i + 1;
//             temp = 0;
//         }
//         else temp = 0;
//    }
//    return row;
// }

// void Show2dArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Show2dArray(CreateArray2d);
// int TempRows = MinRowArray(CreateArray2d);
// Console.WriteLine();
// Console.WriteLine($"Строка с наименьшей суммой элементов {TempRows} .");




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int n = 4;
// int[,] array = new int [n, n];
// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= array.GetLength(0) * array.GetLength(1)){
//   array[i,j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < array.GetLength(1) - 1) 
//     j++;
//   else if (i < j && i + j >= array.GetLength(0) - 1) 
//     i++;
//   else if (i >= j && i + j > array.GetLength(1) - 1)
//     j--;
//   else i--;
  
// }

// void Array2D (int[,] array){
//   for (int i = 0; i < array.GetLength(0); i++){
//     for (int j = 0; j < array.GetLength(1); j++){
//       if (array[i,j] / 10 <= 0) Console.Write($" {array[i,j]} ");
//       else Console.Write($"{array[i,j]} ");
//       }
//       Console.WriteLine();
//   }
// }
// Array2D(array);



