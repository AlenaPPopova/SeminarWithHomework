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

//или

// void Polindrom(int a){
//     if ((a / 10000 == a % 10) && ((a / 1000) % 10 == (a % 100) / 10)){  // main check number
//         Console.WriteLine("This is polindrom.");                        // if number is polindrom
//         }
//     else {
//         Console.WriteLine("This is NOT polindrom.");                    // if number is not polindrom
//     }
// }
// while(true){                                                            // infinite cycle for testing
//     Console.WriteLine("Input 5-th numbers:");
//     int a = Convert.ToInt32(Console.ReadLine());
//     if (a >9999 && a < 100000) Polindrom(a);                            // fool protection
//     else Console.WriteLine("Ввод не соответствует условию!");


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


//или

// double Line3D (int x1, int y1, int z1, int x2, int y2, int z2){
//     return Math.Sqrt((Math.Pow((x2 - x1), 2))                       // return solution
//                    + (Math.Pow((y2 - y1), 2))
//                    + (Math.Pow((z2 - z1), 2)));
// }
// Console.WriteLine("Введите координаты 1-й точки:");
// Console.Write("x1 = : ");
// int x1 = Convert.ToInt32(Console.ReadLine());                       // user input
// Console.Write("y1 = : ");
// int y1 = Convert.ToInt32(Console.ReadLine());                       // user input
// Console.Write("z1 = : ");
// int z1 = Convert.ToInt32(Console.ReadLine());                       // user input
// Console.WriteLine("Введите координаты 2-й точки:");
// Console.Write("x2 = : ");
// int x2 = Convert.ToInt32(Console.ReadLine());                       // user input
// Console.Write("y2 = : ");
// int y2 = Convert.ToInt32(Console.ReadLine());                       // user input
// Console.Write("z2 = : ");
// int z2 = Convert.ToInt32(Console.ReadLine());                       // user input
// Console.WriteLine("Distance between 2 dots in 3D space: "           // function call and
//                   +Math.Round(Line3D(x1, y1, z1, x2, y2, z2), 2));  // output rounded number


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




