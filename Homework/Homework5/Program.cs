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

