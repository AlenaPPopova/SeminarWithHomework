//                               ******ДЗ к 1 семинару******


// //Задача 2. Напишите код, где на вход принимает два числа и выдает какое число больше, какое меньше

// int num1;

// int num2;

// //Ввод данных

// Console.Write("введите число 1: ");
// num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("введите число 2: ");
// num2 = Convert.ToInt32(Console.ReadLine());

// //Запрос данных у пользователя

// if (num1 > num2){
//     Console.WriteLine("Число 1 является максимальным");
// }
// else{
//     Console.WriteLine("Число 2 является максимальным");
// }

// //Вычисление и ответ



// //Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

// int num1;
// int num2;
// int num3;
// //Ввод данных

// Console.Write("введите число 1: ");
// num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("введите число 2: ");
// num2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("введите число 3: ");
// num3 = Convert.ToInt32(Console.ReadLine());

// //Запрос данных у пользователя

// if(num1 > num2)
// Console.WriteLine("Число 1 является максимальным");
 
//      while(num1 < num3)
//      Console.WriteLine("Число 3 является максимальным");
        
// if(num1 < num2)
//      Console.WriteLine("Число 2 является максимальным");

//      while(num2 < num3)
//      Console.WriteLine("Число 3 является максимальным");

// //Вычисление и ответ



// //Задача 6. Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка)?

// int num;
// //Ввод данных

// Console.Write("введите число 1: ");
// num = Convert.ToInt32(Console.ReadLine());
// //Запрос данных у пользователя

// if(num%2 == 0)
// Console.WriteLine("Вывод число четное");

// else Console.WriteLine("Вывод число нечетное");

// //Вычисление и ответ



// //Задача 8. Напишите программу, которая на вход принимает число (N),а на выходе показывает  все четные числа от 1 до N/

// int num;
// int even = 1;

// //Ввод данных

// Console.Write("Введите число: ");

// //Запрос данных у пользователя

// num = Convert.ToInt32(Console.ReadLine());

// while(even<=num){
//     if (even % 2 == 0){
//     Console.Write(even + "");
//     }
//     even++;
// }
// //Вычисление и ответ





                           //*****Дз к семинару2*****

// //  Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// //показывает вторую цифру этого числа.

// int Number(){
//     int num = new Random().Next(100,1000);
//     Console.WriteLine("Number is - " + num);
//     int dec = num / 10;
//     int ed = dec % 10;
//     int result = ed;
//     return result;
// }

// int number = Number();
// Console.WriteLine("Number is -" + number);



// // // //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// // что третьей цифры нет.

// void Third(int a){
//     while(a >= 1000){
//         int ed = a / 10;
//         a = ed;
//     }
//     if(a<1000){
//         int num = a % 10;
//         Console.WriteLine("Третья цифра - " + num);
//     }
//     if(a < 100){
//         Console.WriteLine("Третьей цифры нет");
//     }
// }
// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Third(a);



// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// //  и проверяет, является ли этот день выходным.


// void Week(int num){
//     if (num == 6 || num == 7){
//     Console.WriteLine("Is day off");
//     }
//     else if (num < 1 || num > 7){
//     Console.WriteLine("No day of the week!!!");
//     }
//     else{
//     Console.WriteLine("Weekdays");
//     }
// }
// Console.Write("Enter number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Week(num);







//                               ***** ДЗ К СЕМИНАРУ 3*****

//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


// void Pal(){
//     int num=new Random().Next(10000, 100000);
//     Console.WriteLine("Введите число: " + num);
//     int st1=0;
//     int st2=0;
//     int st3=0;
//     int ed1=0;
//     int ed2=0;
//     int ed3=0;
//     st1=num % 10;
//     st2=num % 100;
//     st3=st2 / 10;
//     ed1=num / 10000;
//     ed2=num / 1000;
//     ed3=ed2 % 10;
//     if(st1 == ed1 && st3 == ed3){
//          Console.WriteLine("Число является палиндромом");
//     }
//     else{
//         Console.WriteLine( "Число НЕ является палиндром");
//     }  
// }    
//  Pal();



// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


// double Coor(double x1, double y1, double z1, double x2, double y2, double z2){
//     double distance = 0;
//     distance= Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
//     Console.WriteLine("Расстояние в 3 D: " + distance);
//     return distance;
// }     
// Console.Write("Введите координаты точки x1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты точки y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты точки z1: ");
// double z1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты точки x2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты точки y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты точки z2: ");
// double z2 = Convert.ToDouble(Console.ReadLine());

// Coor(x1, y1, z1, x2, y2, z2);




// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
  

// void Cube(int a){
//     int count=1;
//     while(count <= a){
//          Console.Write( count * count * count + "  ");
//          count++;
//     }  
// }
// Console.Write("Введите число: ");
// int num=Convert.ToInt32(Console.ReadLine());
// if (num<=0) Console.Write("Ввод не верный.");
// else {
//     Cube(num);
// }




//           ****** ДЗ  К СЕМИНАРУ 4********



//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


// void NatDeg(int A, int B){
//     int result=1;
//     for(int i=1; i <= B; i++){
//         result = result * A;
//     }
//     Console.WriteLine($"Натуральная степень числа {A} равна {result}");
// }

// Console.WriteLine("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число В: ");
// int B = Convert.ToInt32(Console.ReadLine());
// NatDeg(A,B);





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 1 ВАРИАНТ РЕШЕНИЯ.

// void Suma(int num){
//     int result = 0;
//     for (int i = 0; i <= num; i++){
        
//         result += num % 10;
//         num = num / 10;
//     }
//     Console.WriteLine($"Сумма введенного числа равна {result}");
// }

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Suma(num);


//2 ВАРИАНТ РЕШЕНИЯ.

// int Sum (int num){
//     int result = 0;

//     for (int i = 1; i <= num; num /= 10){
//         result += num % 10;
//     }
//     return result;
//     }

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Sum(number));



// Задача 29: Напишите программу, которая задаёт массив из произвольн элементов и выводит их на экран.


// int[] Array(int size){
//     int[] numbers = new int[size];
//     for (int i = 0; i < numbers.Length; i++){
//         Console.Write("Введите число массива: ");
//         numbers[i] = Convert.ToInt32(Console.ReadLine());
//         }
//         return numbers;
// }

// void ShowArray(int[] array){
//     Console.Write("[ ");
//     for(int count=0; count<array.Length; count++){
//         Console.Write(array[count]+ " ");
//     }
//     Console.Write("]");
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// ShowArray(Array(size));




//                    ******ДЗ к 5 семинару********


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


// int[] CreateRandomArray(int size, int min, int max){       
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
// Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальный элемент массива от 100 до 999: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный элемент массива от 100 до 999: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(size,min,max);
// ShowArray(array);
// int chet = ChetNum(array);
// Console.WriteLine();
// Console.WriteLine($"Количество четных чисел в массиве = {chet}");


//P.S.: ввела ограничения на рандом для 3х значных чисел, но указать могу и двузначное, выдает как-то коряво ответ. Не могу разобраться,возможно необходимо что-то дописать на ограничения?! Прошу вашего комментария.



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


// int[] CreateRandomArray(int size, int min, int max){       
//     int[] array = new int[size];
//     for(int i=0; i<size; i++){
//         array[i] = new Random().Next(min, max+1);  
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

// Console.WriteLine("Ведите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальный элемент массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный элемент массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] array = CreateRandomArray(size,min,max);
// ShowArray(array);
// int sumnegativ = SumNegEl(array);
// Console.WriteLine();
// Console.WriteLine($"Сумма элементов стоящих на нечетных позициях  массива равна {sumnegativ}.");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


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



//   НЕ РЕШЕНА.
// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Приравниваем два уравнения k1*x+b1 = k2*x+b2
//Выводим x в одну сторону k1*x-k2*x = b2-b1
//Выводим х за равно x = (b2-b1) / (k1-k2)

//// x=(b2-b1)/(k1-k2);
// y=(k1*(b2-b1))/(k1-k2)+b1;

// double A1 = k1*x+b1;
// double A2 = k2*x+b2;
// double B1 = k1*x-k2*x;
// double B2 = b2-b1;
// double C = k1-k2;

//  int InterPoint (int k1, int b1, int k2,int b2, int x, int y){
//     if(k1 == k2 && b1 == b2) Console.WriteLine("Прямые линии совпадают");
//     else if(k1 == k2) Console.WriteLine("Прямые линии параллельны");
//     else
//  }

// double[] Dec(double[,] count){
//     double[,] coeff = new double[2, 2];
//     double[] crossPoint = new double[2];{
//         crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
//         crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
//     }
//     return crossPoint;
// }

// void OutputResponse(double[,] coeff){
//     if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]){
//         Console.Write($"Прямые совпадают");
//         }
//     else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]){
//         Console.Write($"Прямые параллельны");
//         }
//     else Console.Write($"Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  
// }






//         *******ДЗ К 7 СЕМИНАРУ*******

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// double [,] NewArray(double m, double n, double min, double max){
//     double[,] array = new double[m, n];
//     for(double i = 0; i<m; i++){                            
//         for(double j = 0; j<n; j++){
//             array[i,j] = new Random().NextDouble(min, max+1);
//             Console.Write("{0,4}", array[i, j]);
//         }     
//     }    
//     return array;
// }

// double [,] NewArray(double m, double n, double min, double max){
//     double[,] a = new double[m, n];
//     Random random = new Random();
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             a[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
//             Console.Write("{0,6:F2}", a[i, j]);
//         }
//     Console.WriteLine();
//     }
// }
// double
// NewArray(m,n,min,max);







// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет
// 1,2 -> 2



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


