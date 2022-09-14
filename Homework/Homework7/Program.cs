//         *******ДЗ К 7 СЕМИНАРУ*******

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] RandomArray2d(int m, int n){
//     double[,] array = new double[m, n];
//     for(int i = 0; i<m; i++){                              
//         for(int j = 0; j<n; j++){
//             array[i,j] = new Random().NextDouble() * 10;      //чтобы получить цифру до 10,0(с запятой)
//         }                                                      //если *100 то до 100,0
//     }      
//     return array;
// }

// void ShowMe2dArray(double[,] array){                      
//     for(int i = 0; i<array.GetLength(0); i++){        
//         for(int j = 0; j<array.GetLength(1); j++){    
//             Console.Write(Math.Round(array[i,j], 1) + " ");     //округляет до 1 цифры после запятой.
//         }                                                       //Math.Round Округляет значение до ближайшего целого
//         Console.WriteLine();                                    //или указанного количества десятичных знаков.
//     }
// }

// Console.Write("Введите размер m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размер n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] array = RandomArray2d(m, n);
// Console.WriteLine();
// ShowMe2dArray(array);




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет
// 1,2 -> 2

// int[,] array = {{1, 4, 7, 2},                                  
//                 {5, 9, 2, 3},
//                 {8, 4, 2, 4}};
                
                
// void SearchElementArray(int i, int j, int[,] array){
//     if(i < array.GetLength(0) && j < array.GetLength(1))          // ищет существует такая позиция
//         Console.WriteLine($"Array[{i},{j}] = {array[i,j]}");      
//     else Console.WriteLine($"Array[{i},{j}] doesn't exist!");     
// }

// Console.Write("Введите позицию m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите позицию n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// SearchElementArray(m,n, array);




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.




// double[,] CreateRandom2dArray(int a, int b){
//     double[,] array = new double[a,b];
//     for (int i = 0; i < a; i++){
//         for (int j = 0; j < b; j++){
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }

// void Create2dArray(double[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void Show2dArray(double[,] array){
//     double sum;
//     for (int j = 0; j < array.GetLength(1); j++){
//         sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++){
//             sum = sum + array[i, j];
//         }
//         sum = sum / array.GetLength(0);
//         Console.Write($"{sum} ");
//     }
// }
// Console.WriteLine("Введите количество строк массива: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива: ");
// int b = Convert.ToInt32(Console.ReadLine());
// double[,] array = CreateRandom2dArray(a, b);
// Create2dArray(array);
// Console.WriteLine();
// Console.Write($"Среднее арифметическое по каждому столбцу в массиве: ");
// Console.WriteLine();
// Show2dArray(array);