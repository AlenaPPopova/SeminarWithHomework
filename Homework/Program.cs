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

// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size, int min, int max){       
//     int[] array = new int[size];
//     for(int i=0; i<size; i++){
//         array[i] = new Random().Next(100, 1000);   //СОМНЕВАЮСЬ В ЭТОЙ СТРОЧКЕ,ХОТЕЛА ОГРАНИЧЕНИЯ ВВЕСТИ Д/3-х ЗНАЧ ЧИСЕЛ
//     }                                              //НО В ИТОГЕ НЕ РАБОТАЕТ,ВОЗМОЖНО НЕДОРАБОТАЛА ГДЕ-ТО(( 
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

// int Diff(int []array){
//     int min = array[0];
//     int max = array[0];
//     int result = 0;
//     for (int i = 0; i < array.Length; i++){
//         if (array[i] < min){ 
//             min = array[i];
//         }
//         else 
//             max = array[i];  
//             result = max - min;     
//     }
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
// int maxmin = Diff(array);
// Console.WriteLine();
// Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {maxmin}.");
