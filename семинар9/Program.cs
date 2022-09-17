// //Задача. Задайте значение N. Введите все натуральные числа от 1 до N.

// //Запрос данных от пользователя
// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "1");   //??"" привводе пробела пользователем вернется то что написано
//     return num;                                       // в кавычках
// }

// //Рекурсия(рекурсивный вызов) чисел от 1 до N
// string Recurs(int num)
// {
//     if (num <= 1)
//     {
//         return "1";
//     }
//     else
//     {
//         string outline = Recurs(num - 1) + " , " + num;   //num + " , " + numRecurs(num - 1) обратный порядок цифр
//         return outline;
//     }
// }

// //Вывод результата
// void PrintData(string prefix, string num)
// {
//     Console.WriteLine(prefix + num);

// }

// int InputNumber = ReadData("Введите число N: ");
// string outline = Recurs(InputNumber);
// PrintData("Числа от 1 до N: ", outline);



//Задача. Напишите программу ,которая на вход принимает несколько чисел и выводит сумму этих чисел.

// //Запрос данных от пользователя
// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "1");   //??"" привводе пробела пользователем вернется то что написано
//     return num;                                       // в кавычках
// }

// //Метод рекурсии. Рекурентно считает сумму цифр.
// int SumRec(int num){
//     //точка остановки рекурсии
//     if(num<=0){
//         return 0;
//     }
//     else{

//         int sum = 0;
//         //Рекурентный вызов метода
//         sum = num%10 + SumRec(num/10);
//         return sum;
//         // или вместо 49,51,52 return num%10 + SumRec(num/10)
//     }
// }

// //Метод While
// int SumWhile(int num){
//     int sum = 0;
//     while(num>0){
//         sum = sum+num%10;
//         num = num/10;
//     }
//     return sum;
// }

// //Вывод результата
// void PrintData(string prefix, string num)
// {
//     Console.WriteLine(prefix + num);

// }

// int InputNumber = ReadData("Введите ряд чисел: ");

// //Проверяем сколько работает какждый из методов
// DateTime d1 = DateTime.Now;
// int sumDigist1 = SumRec(InputNumber);
// PrintData("Время работы рекурсии: ", (DateTime.Now - d1).ToString());

// DateTime d2 = DateTime.Now;
// int sumDigist2 = SumWhile(InputNumber);
// PrintData("Время работы while: ", (DateTime.Now - d2).ToString());

// PrintData("Сумма цифр в числе: ",sumDigist1.ToString());
// PrintData("Сумма цифр в числе: ",sumDigist2.ToString());



//Задача 69. Напишите программу , которая на вход принимает 2 числа A и B и возводит число A в целую степень В.

//Запрос данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "1");   //??"" привводе пробела пользователем вернется то что написано
    return num;                                       // в кавычках
}

//Рекурентное возведение в степень
long PowRec(int numA, int numB)
{
    //Точка остановки
    if (numB <= 0)
    {
        return 1;
    }
    else
    {
        //Рекурентный вызов
        return numA * PowRec(numA, numB - 1);
    }

}

//Рекурентное возведение в степень с разбиением на части
long MyPowRec(int numA, int numB)
{
    //Точка остановки
    if (numB == 2)
    {
        return numA * numA;
    }
    //Точка остановки
    if (numB == 1)
    {
        return numA;
    }
    if (numB % 2 == 0)
    {
        return PowRec(numA, numB / 2) * PowRec(numA, numB / 2);
    }
    else
    {
        return PowRec(numA, numB / 2) * PowRec(numA, numB / 2 + 1);
    }
}

//Вывод результата
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);

}


int numA = ReadData("Введите число А: ");
int numB = ReadData("Введите число B: ");

DateTime d1 = DateTime.Now;
long resPow1 = PowRec(numA, numB);
PrintData("Время работы PowRec: ", (DateTime.Now - d1).ToString());

DateTime d2 = DateTime.Now;
long resPow2 = MyPowRec(numA, numB);
PrintData("Время работы MyPowRec: ", (DateTime.Now - d2).ToString());

DateTime d3 = DateTime.Now;
long resPow3 = (long)Math.Pow(numA, numB);
PrintData("Время работы Math.Pow: ", (DateTime.Now - d3).ToString());

PrintData("Число " + numA + " в степени " + numB + ":", resPow1.ToString());
PrintData("Число " + numA + " в степени " + numB + ":", resPow2.ToString());
PrintData("Число " + numA + " в степени " + numB + ":", resPow3.ToString());