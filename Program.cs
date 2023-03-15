// Знакомство с языками программирования
// Урок 9. Рекурсия
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите натуральное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// NaturalNumbers(number);

// void NaturalNumbers(int num)
// {
//     if(number<=0)
//      {
//         Console.WriteLine("Введенное число не является натуральным");
//         return;
//      }
//     Console.Write($"{num} ");
//     if (num == 1) return;
//     NaturalNumbers(num - 1);   
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите число M: ");
// int numberM = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

// NaturalNumbers(numberM, numberN);
// int NaturalNumbers(int numM, int numN)
// {
//     if (numM > numN) return numN + NaturalNumbers(numN + 1, numM);
//     return numM == numN ? numM : numM + NaturalNumbers(numM + 1, numN);
// }

// int numbersNatural = NaturalNumbers(numberM, numberN);
// Console.WriteLine(numbersNatural);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.WriteLine("Вычисление функции Аккермана");
// Console.WriteLine("Желательно вводить одно из значений от 0 до 3, иначе расчет уходит в бесконечность!!!");
// Console.WriteLine("Введите по очереди два числа m и n: ");
// int numberM = Convert.ToInt32(Console.ReadLine());
// int numberN = Convert.ToInt32(Console.ReadLine());

// AkkermanFunction(numberM, numberN);
// int AkkermanFunction(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return AkkermanFunction(m - 1, 1);
//     else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
// }

// Console.Write("-> A(m,n) = ");
// int functionAkkerman = AkkermanFunction(numberM, numberN);
// Console.WriteLine(functionAkkerman);
