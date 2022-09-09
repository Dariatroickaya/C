// int Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if(n == 1) return 1;
//     else return n * Factorial(n-1);
// }

// Console.WriteLine(Factorial(3));        // 1 * 2 * 3 = 6





// // возникает проблема с вычислением больших чисел (получаются отрицат.числа из-за переполнения типа)
// int Factorial(int n)       //нужно заменить int на double
// {
//     // 1! = 1
//     // 0! = 1
//     if(n == 1) return 1;
//     else return n * Factorial(n-1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }


double Factorial(int n)       
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}