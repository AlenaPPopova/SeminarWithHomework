int num;

Console.Write("ВВедите число: ");
num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while(current<=num){
    Console.Write(current + "");
    current++;
}


