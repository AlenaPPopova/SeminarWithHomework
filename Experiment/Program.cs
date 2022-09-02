//Задача на подумать!!! Написать прогу, кот принимает на вход координаты 
//двух точек и находит расстояние между ними в 2Д пространстве
// А(3,6); B(2,1) - 5,09
// А(7,-5); B(1,-1) - 7,21


// double Avarage(double x1, double y1, double x2, double y2){

// double distance=0;
// distance= Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
// Console.WriteLine("Расстояние в 2 D:   "  + distance);
// return distance;
// }     


// Console.Write("Введите координаты x1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты x2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());


// Avarage(x1, y1, x2, y2);







// // Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//
// void Pall(num){
//     int (num) = 0;
//     if (number[0]==number[4] || number[1]==number[3]){
//     Console.WriteLine($"Ваше число: {number} - палиндром.");
//   }
//   else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
// }

// if (number!.Length == 5){
//   CheckingNumber(number);
// }
// else Console.WriteLine($"Введи правильное число");

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Pall(num);


Задача . в 3д пространстве

static void Main(string[] args){
        char selection;
        Double x1, x2, y1, y2, z1, z2, distance;

        
      
Console.Write("Введите координаты x1: ");
                x1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты x2: ");
                x2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты y1: ");
                y1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты y2: ");
                y2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты z1: ");
                z1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты z2: ");
                z2 = Convert.ToDouble(Console.ReadLine());

                distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
                selection = Convert.ToChar(Console.ReadLine());
                Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
                Console.ReadKey();
