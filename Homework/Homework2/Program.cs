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

// или

// int secondDigit (int a){
//     int result = a / 10;                                            // delete right digit
//     result = result % 10;                                           // delete left digit
//     return result;
// }
// while(true){                                                        // infinite cycle for testing
//     Console.WriteLine("Введите 3-х значное число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     if (a > 99 && a < 1000){
//         Console.WriteLine("Вторая цифра числа: " + secondDigit(a)); // call function
//     }
//     else{
//         Console.WriteLine("Число не соответствует условию!");       // call function
//     }
// }


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


//или

// int week (int a){
//     if (a > 0 && a < 6){ return 0; }                    // if workday
//     else if (a > 5 && a < 8) { return 1; }              // if weekend
//     else { return -1; }                                 // if bad input
// }
// while(true){                                            // cycle for testing
//     Console.WriteLine("Введите цифру дня недели: ");
//     int day = Convert.ToInt32(Console.ReadLine());
//     if(week(day) == 0) {Console.WriteLine("Это рабочий день!");}
//     else if(week(day) == 1) {Console.WriteLine("Это выходной день!");}
//     else if(week(day) == -1) {Console.WriteLine("Ошибка ввода!");}


