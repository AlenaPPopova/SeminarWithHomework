//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// void Numbers(int num){
//     int result=0;
//     for (int curr = 1; curr <= num; curr++){
//         result += curr;
//     }
//     Console.WriteLine($"Сумма чисел от 1 до {num} равна {result}");
// }

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Numbers(number);



//Задача 2. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// void Numbers(int num){
//     int result = 1;
//     for (int curr=1; curr < num+1; curr++){
//         result = result * curr;
//     }
//     Console.WriteLine($"Произведение чисел от 1 до {num} равна {result}");
// }

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Numbers(num);




// Задача 3. Напишите программу, которая находит в последовательности от 1 до N все нечетные числа

// void Numbers(int number){
//     for (int i = 1; i<=number;i+=2){
//         Console.Write(i+" ");
//     }
// }
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Numbers(number);


// Задача. Напишите прог ,которая задает число и выдает количество чисел в нем.

// int Prog (int num){
//     int result = 0;

//     for (int curr = 1; curr <= num; num /= 10){
//          result++;
//     }
//     return result;
//     }

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Prog(number));

// или

// void Qnt(int num){
//     int a = 0;
//     if (num == 0) Console.WriteLine("В числе один знак");
//     for (int curr = num; curr != 0; curr /= 10){
//         a++;
//     }
//     Console.WriteLine($"Количество цифр числе равно {a}");
// }
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Qnt(number);








// //          ******МАССИВЫ******

// Задача 1. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// //[1,0,1,1,0,1,0,0]


// int[] CreateRandomArray(int size){
//     int[] array = new int[size];
//     for (int i=0; i < size; i++){
//         array[i] = new Random().Next(0,2);
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     Console.Write("[ ");
//     for(int i=0; i<array.Length; i++){
//         Console.Write(array[i]+" ");
//     }
//     Console.Write("]");
// }

// Console.Write("Введите кол-во элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// ShowArray(CreateRandomArray(size));






