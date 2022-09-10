//Задача. Создайте двумерный массив из произвольного кол эл.

// int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
//     int[,] array = new int[rows,cols];
//     for(int i = 0; i<rows; i++)                               //Создание массива
//         for(int j = 0; j<cols; j++)
//             array[i,j] = new Random().Next(min,max+1);          
//     return array;
// }

// void ShowMe2dArray(int[,] array){                         //Вывод массива
//     for(int i = 0; i<array.GetLength(0); i++){        //Проход по строкам (0)
//         for(int j = 0; j<array.GetLength(1); j++){    //Проход по столбцам (1)
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandom2dArray(rows,cols,min,max);
// ShowMe2dArray(array);





//Задача.


// int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
//     int[,] array = new int[rows,cols];
//     for(int i = 0; i<rows; i++)
//         for(int j = 0; j<cols; j++)
//             array[i,j] = new Random().Next(min, max+1);
//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// int CalcSumDiag(int[,] array){
//     int sum = 0;
//     if(array.GetLength(0) == array.GetLength(1)){
//         for(int i = 0; i<array.GetLength(0); i++){
//             sum += array[i,i];
//         }
//     }
//     return sum;
// }




// //Задача на поиск квадратов у четных индексов:
// int[,] ChangeArrayKwad(int[,] array){
// for(int i = 0; i<array.GetLength(0); i++){
//     for(int j = 0; j<array.GetLength(1); j++){
//         if(i%2==0 && j%2==0){
//             array[i,j] *= array[i,j];
//         }
//     }
// }
// return array;
// }




// //Задача на задание значения элемента массива равное сумме его индексов:
// int[,] Create2dArray(int rows, int cols){
//     int[,] array = new int[rows,cols];
//     for(int i = 0; i<rows; i++){
//         for(int j = 0; j<cols; j++){
//             array[i,j] = i+j;
//         }
//     }
//     return array;
// }


// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandom2dArray(rows,cols,min,max);
// Show2dArray(array);
// int sum = CalcSumDiag(array);
// Console.WriteLine("Sum of numb on main is: " + sum);




//Задача 48: Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// Выведите полученный массив на экран.

// int[,] Create2dArray(int rows, int cols){
//     int[,] array = new int[rows,cols];
//     for(int i = 0; i<rows; i++){
//         for(int j = 0; j<cols; j++){
//             array[i,j] = i+j;
//         }
//     }
//     return array;
// }


// void ShowMe2dArray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         Console.WriteLine();
//         for (int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//        // Console.WriteLine();
//     }
// }

// Console.Write("Введите число строк: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int[,] array = NewArray(a,b);
// ShowMe2dArray(array);





//Задача 49: Задайте двумерный массив. Найдите элементы, 
//у которых оба индекса чётные, и замените эти элементы на их квадраты.





//Задача 51: Задайте двумерный массив. 
//Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
//     int[,] array = new int[rows,cols];
//     for(int i = 0; i<rows; i++)                               //Создание массива
//         for(int j = 0; j<cols; j++)
//             array[i,j] = new Random().Next(min,max+1);          
//     return array;
// }


// void ShowMe2dArray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         Console.WriteLine();
//         for (int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//     }
// }

// // int CalcSumDiag(int[,] array){
// //     int sum = 0;
// //     if(array.GetLength(0) == array.GetLength(1)){     //Проверяем если кол строк и кол столбцов =,то это квадрат матрица
// //         for(int i=0; i>array.GetLength(0); i++){           //если нет, то возврат,пока не будет квадрата
// //             for(int j=0; j>array.GetLength(1); j++){
// //                 if(i==j) sum += array[i,j];           //если индекс столбца равен индексу строки, то значение записываем
// //             }                                         //в sum и тд суммируем если след сходится
// //         }                                                  
// //     }
// //     return sum;
// // }

//       //ИЛИ
// int CalcSumDiag(int[,] array){
//     int sum = 0;
//     if(array.GetLength(0) == array.GetLength(1)){     
//         for(int i=0; i>array.GetLength(0); i++){           
//             if(i==i) sum += array[i,i];       //ИЛИ  sum += array[i,i];     
//         }                                         
//     }                                                  
//     return sum;
// }

// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandom2dArray(rows,cols,min,max);
// ShowMe2dArray(array);
// int sum = CalcSumDiag(array);
// Console.WriteLine("Sum of numbers on main is: " + sum);






