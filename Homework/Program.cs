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





                           //*****Дз по семинару2*****

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
// !!!!!!!Не решена. В процессе.
   
//  int Number (int num){
//     while (num > 999){
//         int dec = num / 10;
//         int ed = dec % 10;
//         int result = ed;
//         return result;
//     }
//     if (num>99){
//         int Number(num);
//         Console.WriteLine("The third number is - " + Number(num));
//     }
//     else{
//         Console.WriteLine("There is NOT the third number");
//     }
// }

// Console.WriteLine("Enter number: );
// int num = Convert.ToInt32(Console.ReadLine());









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









                    // ***** Дз по семинару3*****

// // Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125                    