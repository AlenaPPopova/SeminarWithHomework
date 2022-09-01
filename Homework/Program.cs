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





                    // ***** Дз по семинару3*****

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





//                            ******ДЗ к семинару 4*******

// //  Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Numbers(int a, int b){
//     int result=0;
//     for (int curr = 1; curr <= num; curr++){
//         result += curr;
//     }
//     Console.WriteLine($"Сумма чисел от 1 до {a} равна {result}");
// }

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Numbers(number);








// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



// Задача 29: Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
