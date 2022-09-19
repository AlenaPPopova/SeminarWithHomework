// //Запрос данных от пользователя
// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "1");  
//     return num;                                       
// }

// //Вывод результата
// void PrintData(string prefix, string num)
// {
//     Console.WriteLine(prefix + num);

// }



// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


// //Рекурс метод
// string NumNM(int m,int n){
//     //Точка остановки рекурсии
//     if (m >= n){
//     return Convert.ToString(m) + " ";
//     }
//     else{
//         string outline = NumNM(m, n-1) + n + " ";
//         return outline;
//     }
// }

// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string res = (m<n) ? (NumNM(m,n)) : (NumNM(n,m));
// PrintData("Натуральные числа в промежутке от "+m+" до "+n+" : " , res);



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumMN(int m, int n){
//     if(m <= n){
//         int result = 0;
//         return result = n + SumMN(m,n-1);
//     }
//     //Точка остановки рекурсии
//     else{
//         return 0;
//     }
// }
// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int result = SumMN(m,n);
// Console.WriteLine(result);



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

// int AccermanFun(int m,int n){
//     if(m == 0){
//         return n + 1;
//     }
//     else{
//         //Рекурсивный метод
//         if(m != 0 && n == 0){
//             return AccermanFun(m-1, 1);
//         }
//         else{
//             return AccermanFun(m-1, AccermanFun(m, n-1));  //m!=0,n!=0
//         }
//     }
// }

// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int res = AccermanFun(m,n);
// Console.WriteLine(res);




