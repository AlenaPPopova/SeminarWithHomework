//****** ДЗ К 6 СЕМИНАРУ*******

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

