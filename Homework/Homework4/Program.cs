////           ****** ДЗ  К СЕМИНАРУ 4********

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

//или 


// Console.WriteLine("Введите основание: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// for (int i = 0; i < b; i++){                    // cycle
//     result *= a;                                // main iteration
// }
// Console.WriteLine("---------------------");
// Console.WriteLine($"{a} в степени {b} = {result}");
// Console.WriteLine("---------------------");



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
