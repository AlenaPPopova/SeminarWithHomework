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

// или

// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int i = 2;
// while (i <= a){
//     Console.Write(i);
//     if (i+1 < a){
//         Console.Write(", ");
//     }
//     i = i + 2;
// }
// Console.WriteLine();