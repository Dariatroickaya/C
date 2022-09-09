﻿// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

// int Fibonacci(int n)
// {
//     if(n == 1 || n == 2) return 1;                //оператор или ||
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }

// for (int i = 1; i < 10; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }




// попробуем поменять тип данных на double

double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;                //оператор или ||
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}