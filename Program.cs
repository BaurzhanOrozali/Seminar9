// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void NumMin (int num)
{
      Console.Write(num + " ");
    if (num > 1) NumMin(num - 1);
}
Console.Write("\nInput yours number: ");
int n = Convert.ToInt32(Console.ReadLine());
NumMin(n);

*/

//---------------------------------------------------------------------------------------------------------
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
int NumMin (int num, int m)
{
    if ( num == m) return m;
    else return (NumMin(num + 1, m) + num);
    
}
Console.Write("\nInput yours number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("\nInput yours number: ");
int k = Convert.ToInt32(Console.ReadLine());

Console.Write(NumMin(n, k));
*/


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



int AkkermanFunction(int i, int j)
{
    if(i == 0)
        return j + 1;
    else if(j == 0)
        return AkkermanFunction(i - 1, 1);
    else 
        return AkkermanFunction(i - 1, AkkermanFunction(i, j - 1)); 
}
Console.Write("Enter first m parameter: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter first n parameter: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Akkerman function f({m}, {n}) = {AkkermanFunction(m, n)}");