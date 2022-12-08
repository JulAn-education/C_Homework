//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;
{
    Console.Write(max);
}

*/

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

    Console.Write(max);

*/

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*

Console.Write("Input a number: ");
double num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
    Console.Write("Yes!");

else 
    Console.Write("No!");

*/

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;

while (current <= num)
{
    if (current % 2 == 0)
    { 
    Console.Write(current + " ");
    }
    current++;
}

*/


// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*

int MetNum(int num)
{
    int result = num % 100 / 10;
    
    return result;
}

Console.Write("Введите трехзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());


int newNum = MetNum(num1);
Console.WriteLine($"Вторая цифра числа {num1} - {newNum}");

*/

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.Write("Input a number: ");
int newNum = Convert.ToInt32(Console.ReadLine());
string newNumText = Convert.ToString(newNum);

if (newNumText.Length > 2)
{
  Console.WriteLine("Third number " + newNumText[2]);
}
else 
{
  Console.WriteLine("No third digit");
}
*/

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool MetDayoff(int date)
{
    if (date == 6 || date == 7)
    {
        return true;
    }
    
    else
    {
    
        return false;   
    }
}

int randNum = new Random().Next(1, 8);
bool newNum = MetDayoff(randNum);
Console.WriteLine($"Число {randNum} {newNum}");

