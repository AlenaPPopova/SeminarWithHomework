// //Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа

// int cutNumber(){
//     int num = new Random().Next(100,1000);
//     Console.WriteLine("Number is - " + num);
//     int dec = num / 100;
//     int ed = num % 10;
//     int result = dec*10 + ed;
//     return result;
// }

// int number = cutNumber();
// Console.WriteLine("Cut number is -" + number);


// //С функцией void, не возвратный метод решения.
// void CutNumber(){
//      int num = new Random().Next(100,1000);
//      Console.WriteLine("Number is - " + num);
//      int dec = num / 100;
//      int ed = num % 10;
//      int result = dec*10 + ed;
//      Console.WriteLine("Cut number is -" + result);
// }

// CutNumber();

// //Нахождение факториала

// int Factorial(int num){
//     int current = 1;
//     int fact = 1;
//     while(current<=num){
//         fact = fact * current;
//         current++;      //current = current + 1
//     }
//     return fact;
// }

// int result = Factorial(5) * Factorial(3);
// Console.WriteLine("Your result is - " + result);

