
//                    ******ДЗ к 5 семинару********


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


// int[] CreateRandomArray(int size){       
//     int[] array = new int[size];
//     for(int i=0; i<size; i++){
//         array[i] = new Random().Next(100, 1000);   
//     }                                              
//     return array;
// }
// void ShowArray(int[] array){   
//     Console.Write("[ ");                   
//     for(int i = 0; i<array.Length; i++){
//     Console.Write($"{array[i]} ");
//     }
//     Console.Write("]");
// }
// int ChetNum(int[] array){                 
//     int count = 0;                               
//     for(int i=0; i<array.Length; i++){
//         if(array[i]%2 == 0) count++;       //проверяем четный ли эл
//     }
//     return count;
// }

// Console.WriteLine("Input size array:");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(size);
// ShowArray(array);
// Console.WriteLine();
// Console.WriteLine($"Number of even numbers in array: {ChetNum(array)}");




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


// int[] CreateRandomArray(int size){       
//     int[] array = new int[size];
//     for(int i=0; i<size; i++){
//         array[i] = new Random().Next();  
//     }
//     return array;
// }
// void ShowArray(int[] array){                              
//     for(int i = 0; i<array.Length; i++){
//     Console.Write($"{array[i]} ");
//     }
// }
// int SumNegEl(int[] array){
//     int sumnegativ = 0;
//     for(int i = 0; i < array.Length; i++){
//         if (i % 2 != 0) sumnegativ += array[i];    
//     }
//     return sumnegativ;
// }

// Console.WriteLine("Input size array:");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(size);
// ShowArray(array);
// Console.WriteLine();
// Console.WriteLine($"Sum to odd elements: {SumNegEl(array)}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//Точный вариант решения задачи.

// double[] Array(int size){
//     double[] array = new double[size];
//     for (int i = 0; i < size; i++){
//         array[i] = new Random().Next(-100, 101);       //  Создание массива случ веществ числами
//     }
//     return array;
// }
// double DiffNum(double[] array){
//     double min = array[0];
//     double max = array[0];
//     double res = 0;
//     for (int i = 0; i < array.Length; i++){
//         if (array[i] < min) min = array[i];           
//         else if (array[i] > max) max = array[i];       
//     }
//     Console.WriteLine($"Max number in array: {max}");
//     Console.WriteLine($"Min number in array: {min}");
//     res = max - min;                                   
//     return res;
// }
// void ShowArray(double[] array){                        
//     for(int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");                 
//         }
// }
// Console.WriteLine("Input size array:");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] array = Array(size);
// ShowArray(array);
// Console.WriteLine();
// Console.WriteLine($"Difference between max and min array numbers: {DiffNum(array)}"); 


// Решение задачи, где код работает через раз.

// int[] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++){
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }
// void ShowArray(int[] array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }

// int Differ(int[] array){
//     int min = array[0];
//     int max = array[0];
//     int result = 0;
//     for (int i = 1; i < array.Length; i++){
//         if (array[i] < min){ 
//             min = array[i];
//         } 
//         else if (array[i]>max){
//             max = array[i];           
//             }
//     }
//     result = max - min;
//     return result;
// }


// Console.WriteLine("Ведите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное число : ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное число : ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] array = CreateRandomArray(size,min,max);
// ShowArray(array);
// int maxmin = Differ(array);
// Console.WriteLine();
// Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {maxmin}.");






//                  ****** ДЗ К 6 СЕМИНАРУ*******

// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int[] NumberArray(int size){      
//     int[] array = new int[size];
//     for(int i=0; i<size; i++){
//         Console.Write("Input number: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }    
// int PositivElement(int[] array){
//     int count = 0;
//     for(int i = 0; i < array.Length; i++){
//         if(array[i] > 0) count++;
//     }
//     return count;
// }

// Console.Write("Enter the the size of the array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = NumberArray(size);
// int count = PositivElement(array);
// PositivElement(array);
// Console.WriteLine($"The number of elements is greater than 0: {count}");




// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Приравниваем два уравнения k1*x+b1 = k2*x+b2
//Выводим x в одну сторону k1*x-k2*x = b2-b1
//Выводим х за равно x = (b2-b1) / (k1-k2)

//// x=(b2-b1)/(k1-k2);
// y=(k1*(b2-b1))/(k1-k2)+b1;

// double[] CrossPoint(double b1, double k1, double b2, double k2){     // ищет точку пересечения
//     double[] array = new double[2];
//     array[0] = (b2 + b1 * (-1)) / (k1 + k2 * (-1));                         //  массив [0] ищет X
//     array[1] = k1 * array[0] + b1;                                          // массив [1] ищет Y
//     return array;                                                           // возвращает оба массива [0]и[1]
// }
// Console.WriteLine("Введите точку b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите точку k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите точку b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите точку k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double[] array = CrossPoint(b1, k1, b2, k2);
// Console.WriteLine($"Точка пересечения двух прямых ({array[0]}, {array[1]})");        


//Решение.

// double[] IntersectionPoint(double b1, double k1, double b2, double k2){     // function for find intersection point
//     double[] array = new double[2];
//     array[0] = (b2 + b1 * (-1)) / (k1 + k2 * (-1));                         // find x
//     array[1] = k1 * array[0] + b1;                                          // find y
//     return array;                                                           // return array with x, y
// }
// Console.WriteLine("Input b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// double[] array = IntersectionPoint(b1, k1, b2, k2);
// Console.WriteLine($"Dot cross 2 lines is ({array[0]}, {array[1]})");        // output solution






//7

// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// double[,] Create2dArray(int m, int n){
//     double[,] array = new double[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             array[i,j] = new Random().NextDouble() * 10; // Filling an array with double type numbers
//         }
//     }
//     return array;
// }

// void Show2dArray(double[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write(Math.Round(array[i,j], 1) + "  "); // Round numbers before condition
//         }
//         Console.WriteLine();
//         Console.WriteLine();
//     }
// }

// Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] array = Create2dArray(m, n);
// Console.WriteLine();
// Show2dArray(array);

/**********************************************************************************************/
/**********************************************************************************************/
/**********************************************************************************************/
/**********************************************************************************************/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// void MainArray(int i, int j, int[,] array){
//     if(i < array.GetLength(0) && j < array.GetLength(1))          // check element is in an array
//         Console.WriteLine($"Array[{i},{j}] = {array[i,j]}");      // output if element is in an array
//     else Console.WriteLine($"Array[{i},{j}] doesn't exist!");     // output if element is not in an array
// }

// int[,] array = {{2, 4, 5, 7, 6},                                  // stock array
//                 {3, 3, 9, 0, 1},
//                 {5, 0, 3, 2, 7},
//                 {9, 8, 2, 1, 0},
//                 {1, 4, 9, 6, 2}};

// Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// MainArray(m,n, array);

/**********************************************************************************************/
/**********************************************************************************************/
/**********************************************************************************************/
/**********************************************************************************************/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

// int[,] Array2D(int m, int n){                            // method of initial 2D array
//     int[,] array = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             array[i,j] = new Random().Next(1,10);        // random filling array with user option
//         }
//     }
//     return array;
// }

// void Show2dArray(int[,] array){                          // method of show 2D array
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// double[] ArrayResult(int[,] array){                      // method of init result array
//     double sum = 0;
//     int m = array.GetLength(0);
//     int n = array.GetLength(1);
//     double[] ArrayResult = new double[n];
//     for(int j = 0; j < n; j++){
//         for(int i = 0; i < m; i++){
//             sum += array[i,j];                                       // sum columns
//         }
//         ArrayResult[j] = Math.Round((Convert.ToDouble(sum/m)), 1);   // find averge of double numbers 
//         sum = 0;
//     }
//     return ArrayResult;
// }

// void ShowArray(double[] array){                          // method of show Array
//     Console.Write("[");
//     for(int i = 0; i < array.Length - 1; i++)
//         Console.Write(array[i] + "; ");
//     Console.Write(array[array.Length - 1] + "]");
//     Console.WriteLine();
// }

// Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (m > 0 && n > 0){                                     // validation user input (fool protect)
//     int[,] array2d = Array2D(m,n);
//     Console.WriteLine();
//     Console.WriteLine("User's 2D array:");
//     Show2dArray(array2d);
//     Console.WriteLine();
//     double[] Result = ArrayResult(array2d);
//     Console.WriteLine("Average numbers is columns:");
//     ShowArray(Result);
//     Console.WriteLine();
// }
// else Console.WriteLine("Fool protect is working. Try again.");


