// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please enter your name : ");

string name = Console.ReadLine();

Console.WriteLine($"Hello {name}");




var number = new int[] { 1, 2, 3, 4, 5 };

for(var num = 0; num<5; num++)
{
    Console.WriteLine(number[num]);
}


int originalNum = 2;

Console.WriteLine("Enter: 1) Add, 2) Subtract, 3) Multiply, 4) Divide");

int action = Convert.ToInt32(Console.ReadLine());

switch (action)
{ 
    case 1:
        Console.WriteLine("Enter the number you would like to Add onto 2: ");
        var inputAddNum = Convert.ToInt32(Console.ReadLine());
        var addEquation = originalNum + inputAddNum;
        Console.WriteLine(originalNum + " + " + inputAddNum + " = " + addEquation);
        break;
    case 2:
        Console.WriteLine("Enter the number you would like to Subtract onto 2: ");
        var subtractNum = Convert.ToInt32(Console.ReadLine());
        var subtractEquation = originalNum - subtractNum;
        Console.WriteLine(originalNum + " - " + subtractNum + " = " + subtractEquation);
        break;
    case 3:
        Console.WriteLine("Enter the number you would like to Multiply onto 2: ");
        var multiplyNum = Convert.ToInt32(Console.ReadLine());
        var multiplyEquation = originalNum * multiplyNum;
        Console.WriteLine(originalNum + " * " + multiplyNum + " = " + multiplyEquation);
        break;
    case 4:
        Console.WriteLine("Enter the number you would like to Divide onto 2: ");
        var divideNum = Convert.ToInt32(Console.ReadLine());
        var divideEquation = originalNum / divideNum;
        Console.WriteLine(originalNum + " / " + divideNum + " = " + divideEquation);
        break;
}