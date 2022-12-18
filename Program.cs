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
*/

// ДЗ 3.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Palindrome (int num1, int num2, int num3, int num4, int num5)
{

    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine("Yes!");
    }
    else
    {
        Console.WriteLine("No!");
    }
}
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите втрое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите четвертое число: ");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите пятое число: ");
int num5 = Convert.ToInt32(Console.ReadLine());

Palindrome (num1, num2, num3, num4, num5);

*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance (double xA, double yA, double zA, double xB, double yB, double zB)
{
    double cat1 = Math.Pow(xB - xA, 2);
    double cat2 = Math.Pow(yB - yA, 2);
    double cat3 = Math.Pow(zB - zA, 2);
    double result = Math.Sqrt(cat1 + cat2 + cat3);
    double newresult = Math.Round(result, 2);
    return newresult;
}
Console.Write("Input the first coordinate xA = ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the second coordinate yA = ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the third coordinate zA = ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input the first coordinate xB = ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the second coordinate yB = ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the third coordinate zB = ");
double zB = Convert.ToDouble(Console.ReadLine());

double res = Distance(xA, yA, zA, xB, yB, zB);
Console.Write(res);

*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void CubeNumber (int num)
{
    int count = 1;
    while (count <= num)
    {
        double cubeNum = Math.Pow(count, 3);
        Console.Write(cubeNum + " ");
        count++;
    }
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
CubeNumber(number);

*/

//ДЗ 4.

//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int MetPow (int num1, int num2)
{
    int result = 1;

    for (int ind = 1; ind <= num2; ind++)
    {
        result = num1 * result;
    }  
    return result;
}

Console.Write("Введите число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int newNum = MetPow(num1, num2);
Console.WriteLine($"Число {num1} в степени {num2} равно {newNum}");

*/


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 

/*
 int SumNumbers(int num)
 {  
    int count = Convert.ToString(num).Length;
    int sum = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      sum = num - num % 10;
      result = result + (num - sum);
      num = num / 10;
    }
   return result;
 }

Console.Write("Введите число: ");
int sumNum  = Convert.ToInt32(Console.ReadLine());
int summ = SumNumbers(sumNum);
Console.WriteLine($"Сумма числа {sumNum} равна {summ}");

*/

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*
int[] CreateArray(int size)
{
    int[] array = new int[size]; 

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input numbers of array for index {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Input a number of elements: ");
int Length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(Length);
ShowArray(myArray);
*/
