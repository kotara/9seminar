// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*

void ShowNum(int num, int count)
{
  if (count > num) return;
  ShowNum(num, count + 1);
  Console.Write(count + ", ");
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
ShowNum(num, count);
Console.Write(1);
*/


//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
void ShowSumm(int one, int two, int summ)
{
  summ = summ + two;
  if (two <= one)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  ShowSumm(one, two - 1, summ);
}


Console.Write("Input first number: ");
int one = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int two = Convert.ToInt32(Console.ReadLine());
int temp = one;

if (one > two) 
{
  one = two; 
  two = temp;
}

ShowSumm(one, two, temp=0);
*/

//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int AckFunc(int one, int two)
{
  if (one == 0) return two + 1;
  else if (two == 0) return AckFunc(one - 1, 1);
  else return AckFunc(one - 1, AckFunc(one, two - 1));
}

Console.Write("Input first number: ");
int one = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int two = Convert.ToInt32(Console.ReadLine());

int functionAkkerman = AckFunc(one, two);

Console.Write($"Функция Аккермана = {functionAkkerman} ");