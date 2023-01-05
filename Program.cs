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

// ДЗ 5.

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*

int [] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

 void EvenNum (int[] array)
{
    int result = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            result = result + 1;   
    }
    Console.WriteLine($"Even numbers is: {result}");  
}

Console.Write("Input a number of elements: ");
int Length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(Length);
ShowArray(myArray);
EvenNum(myArray);

*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    } 
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " "); 
}

void SumNum(int[] array)
{
    int result = 0;

    for (int i = 1; i < array.Length; i+=2)
    {
        result = result + array[i];
        
    }
    Console.WriteLine($"\nSum of numbers in odd positions: {result}");
}

Console.Write("Input a number of elements: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(Length, min, max);
ShowArray(myArray);
SumNum(myArray);

*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
 double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        array[i] = new Random().NextDouble();
        array[i] = Math.Round(new Random().Next(minValue, maxValue + 1)+ new Random().NextDouble(), 2);
    } 
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i] + " "); 
    Console.WriteLine();
}

void DiffArray(double[] array)
{
    double diff = 0;
    double min = array[0];
    double max = array[0];
   
    for (int i = 0; i < array.Length; i++)
    { 
        if (array[i] < min)
        {
            min = array[i];    
        }
        else
        
        {
        if (array[i] > max)
        {
            max = array[i]; 
        }
           
        diff = max - min;
        diff = Math.Round(diff, 2);
        }
       
    }    
    
   Console.Write($"Difference is: {diff}"); 
}

Console.Write("Input a number of elements: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(Length, min, max);
ShowArray(myArray);
DiffArray(myArray);

*/

//ДЗ 6.

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

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
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " "); 
    Console.WriteLine();
}

void PositiveNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)

            count++;
        
    }
    Console.WriteLine($"Number of positive is {count} elements");
}

Console.Write("Input a number of elements: ");
int array = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(array);
ShowArray(myArray);
PositiveNum(myArray);

*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine()); 

double x = 0;
double y = 0;
     
if (k1 != k2) 
{  
    x = -(b1 - b2) / (k1 - k2);
    y = k1 * x + b1;
 
    x = Math.Round(x, 1);
    y = Math.Round(y, 1);

    Console.WriteLine($"Точка пересечения двух прямых ({x}; {y})");
}

else

if (b1 == b2 && k1 == k2)
    Console.WriteLine("Прямые совпадают.");

 */


//ДЗ 9
 
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*

void ShowNum(int n)
{
    Console.Write(n + " ");
    if (n > 1)
    {
        ShowNum(n - 1);
    }
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNum(num);

*/


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int SumNumber(int m, int n)
{

    if (m < n)
    { 
        return m + SumNumber(m + 1, n); 
    }   
    if (n < m) 
    {     
        return m + SumNumber(m - 1, n);  
    } 
    if (m == n)
    {
        return m;
    }
   return 0;
}

Console.Write("Input a number M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number N: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int sum = SumNumber (num1, num2);
Console.WriteLine(sum);

*/



//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0 && m > 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else
    {
        return (AkkermanFunction(m - 1, AkkermanFunction(m, n - 1)));
    }
}

Console.Write("Input a number M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number N: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int function = AkkermanFunction (num1, num2);
Console.WriteLine(function);












