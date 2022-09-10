//Применять

// //result = result * A   или  result += A или *=    /=





// //Задача на подумать!!! Написать прогу, кот принимает на вход координаты 
// //двух точек и находит расстояние между ними в 2Д пространстве
// // А(3,6); B(2,1) - 5,09
// // А(7,-5); B(1,-1) - 7,21


// // double Avarage(double x1, double y1, double x2, double y2){

// // double distance=0;
// // distance= Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
// // Console.WriteLine("Расстояние в 2 D:   "  + distance);
// // return distance;
// // }     


// // Console.Write("Введите координаты x1: ");
// // double x1 = Convert.ToDouble(Console.ReadLine());

// // Console.Write("Введите координаты y1: ");
// // double y1 = Convert.ToDouble(Console.ReadLine());

// // Console.Write("Введите координаты x2: ");
// // double x2 = Convert.ToDouble(Console.ReadLine());

// // Console.Write("Введите координаты y2: ");
// // double y2 = Convert.ToDouble(Console.ReadLine());


// // Avarage(x1, y1, x2, y2);







// // // Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// //
// // void Pall(num){
// //     int (num) = 0;
// //     if (number[0]==number[4] || number[1]==number[3]){
// //     Console.WriteLine($"Ваше число: {number} - палиндром.");
// //   }
// //   else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
// // }

// // if (number!.Length == 5){
// //   CheckingNumber(number);
// // }
// // else Console.WriteLine($"Введи правильное число");

// // Console.Write("Введите число: ");
// // int num = Convert.ToInt32(Console.ReadLine());
// // Pall(num);


// Задача . в 3д пространстве

// static void Main(string[] args){
//         char selection;
//         Double x1, x2, y1, y2, z1, z2, distance;

        
      
// Console.Write("Введите координаты x1: ");
//                 x1 = Convert.ToDouble(Console.ReadLine());

//                 Console.Write("Введите координаты x2: ");
//                 x2 = Convert.ToDouble(Console.ReadLine());

//                 Console.Write("Введите координаты y1: ");
//                 y1 = Convert.ToDouble(Console.ReadLine());

//                 Console.Write("Введите координаты y2: ");
//                 y2 = Convert.ToDouble(Console.ReadLine());

//                 Console.Write("Введите координаты z1: ");
//                 z1 = Convert.ToDouble(Console.ReadLine());

//                 Console.Write("Введите координаты z2: ");
//                 z2 = Convert.ToDouble(Console.ReadLine());

//                 distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
//                 selection = Convert.ToChar(Console.ReadLine());
//                 Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
//                 Console.ReadKey();



// //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3?)
// // 2, 4 -> 16
// void NatDeg(int A, int B){
//     int result=1;
//     for(int i=1; i <= B; i++){          // int result = Math.Pow(numberA, numberB); //return result;               
// }
//         result = result * A;
//     }
//     Console.WriteLine($"Натуральная степень числа {A} равна {result}");
// }

// Console.WriteLine("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число В: ");
// int B = Convert.ToInt32(Console.ReadLine());
// NatDeg(A,B);


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
//     for (int i = 0; i < array.Length; i++){
//         if (array[i] < min){ 
//             min = array[i];
            
//         } 
//         else 
//             max = array[i];           
//     }
//     result = max - min;
//     return result;
// }

// // int Differ(int[] array){
// //     int min = array[0];
// //     int max = array[0];
// //     int result = 0;
// //     for (int i = 0; i < array.Length; i++){
// //         if (array[i] > max){ 
// //             max = array[i];
                
// //         } 
// //         else min = array[i];
           
// //     }
// //     result = max - min;
// //     return result;
// // }

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


// void InputCoefficients(){
//     int[] coeff = 0;
//     for (int i = 0; i < coeff.GetLength(0); i++){
//         Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k1 * x + b):\n"){
//             for (int j = 0; j < coeff.GetLength(1); j++){
//                 if(j==0) Console.Write($"Введите коэффициент k1: ");
//                 else Console.Write($"Введите коэффициент b: ");
//                 int coeff = Convert.ToInt32(Console.ReadLine());
//                 }
//              }
//         }
//     }

// double[] Decision(double[,] count){
//     double[,] coeff = new double[2, 2];
//     double[] crossPoint = new double[2];{
//         crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
//         crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
//     }
//     return crossPoint;
// }

// void OutputResponse(double[,] coeff){
//     if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]){
//         Console.Write($"\nПрямые совпадают");
//         }
//     else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]){
//         Console.Write($"\nПрямые параллельны");
//         }
//     else Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  
// }
// double[,] coeff = new double[2, 2];
// double[] crossPoint = new double[2];
// Decision(coeff);
// InputCoefficients();
// OutputResponse(coeff);