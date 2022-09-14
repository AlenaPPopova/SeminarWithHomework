
//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// int[,] CreateRandomArray(int rows, int cols, int min, int max){       
//     int[,] array = new int[rows,cols];
//     for(int i=0; i<rows; i++)
//         for(int j=0; j<cols; j++)
//         array[i,j] = new Random().Next(min, max+1);  
    
//     return array;
// }
// void ShowArray(int[,] array){                              
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//     Console.WriteLine();
//     }
// }

// int[,] ReturnArray(int[,] array){
//     int temp = 0;
//     for(int j = 0; j<array.GetLength(1); j++){
//         temp = array[0, j];                              //задали пустую переменную
//         array[0, j] = array[array.GetLength(0)-1, j];    //меняем массив местами
//         array[array.GetLength(0)-1, j] = temp;           //замененный массив вкладываем в переменную
//     }
//     return array;
// }

// Console.WriteLine("Введите размер массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер массива: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальный элемент  массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный элемент массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] array = CreateRandomArray(rows,cols,min,max);
// ShowArray(array);
// Console.WriteLine();
// int[,] array2 = ReturnArray(array);
// ShowArray(array2);



//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.
//159    142
//473 => 578
//286    936

// int[,] CreateRandomArray(int rows, int cols, int min, int max){       
//     int[,] array = new int[rows,cols];
//     for(int i=0; i<rows; i++)
//         for(int j=0; j<cols; j++)
//         array[i,j] = new Random().Next(min, max+1);  
    
//     return array;
// }

// void ShowArray(int[,] array){                              
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//     Console.WriteLine();
//     }
// }

// int [,] Reverse2dArray(int[,] array){
//     int temp = 0;
//     for(int i=0; i<array.GetLength(0); i++){
//         for(int j=i+1; j<array.GetLength(1); j++){
//             temp = array[i,j];
//             array[i,j]=array[j,i];
//             array[j,i]=temp;
//         }
//     }
//     return array;
// }

// Console.WriteLine("Введите размер массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер массива: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальный элемент  массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный элемент массива: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandomArray(rows,cols,min,max);
// ShowArray(array);
// Console.WriteLine();
// if(array.GetLength(0) == array.GetLength(1)){    //условие, если матрица не квадратная
//     int[,] array2 = Reverse2dArray(array);
//     ShowArray(array2);
// }
// else
//     Console.WriteLine("Matrix not square.");




//Задайте двумерный массив из целых чисел. Напишите программу, 
//которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива (заменит на 0).

// int[,] CreateRandomArray(int rows, int cols, int min, int max){       
//     int[,] array = new int[rows,cols];
//     for(int i=0; i<rows; i++)
//         for(int j=0; j<cols; j++)
//         array[i,j] = new Random().Next(min, max+1);  
    
//     return array;
// }

// void ShowArray(int[,] array){                              
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//     Console.WriteLine();
//     }
// }

// int[,] ChangeColsRows(int[,] array){
//     int iMin = 0;
//     int jMin = 0;
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j = 1; j<array.GetLength(1); j++){
//             if(array[i,j]<array[iMin,jMin]){
//                 iMin = i;
//                 jMin = j;
//             }
//         }
//     }
//     for(int j = 0; j<array.GetLength(1); j++){
//         array[iMin,j] = 0;
//     }
//     for(int i = 0; i<array.GetLength(0); i++){
//         array[i,jMin] = 0;
//     }
//     return array;
// }

// Console.WriteLine("Введите размер массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер массива: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальный элемент  массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный элемент массива: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandomArray(rows,cols,min,max);
// ShowArray(array);
// Console.WriteLine();
// int[,] array2 = ChangeColsRows(array);
// ShowArray(array2);

