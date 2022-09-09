//                     //
// string[,] table = new string[2,5];
// // String.Empty
// // table [0,0] table [0,1] table [0,2] table [0,4]
// // table [1,0] table [1,1] table [1,2] table [1,4]
// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
// for (int columns = 0; columns < 5; columns++)
// {
// Console.WriteLine($"-{table[rows, columns]}-");
// }
// }





// int[,] matrix = new int[3, 4];

//    //цикл, щелкающий строки
// for (int i = 0; i < 3; i++)            //matrix.GetLength(0) это наша 3 в длине
// {
//     //цикл, щелкающий столбцы
//     for (int j = 0; j < 4; j++)        //matrix.GetLength(1) это наша 4 в длине
//     {
//       Console.Write($"{matrix[i, j]} ");
//     }

// Console.WriteLine();
// }




// метод вывода на экран массива
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

// int[,] matrix = new int[3, 4];

// PrintArray(matrix);



// метод заполнения массива случайными числами

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);//[1; 10)
        }
    }
}

int[,] matrix = new int[3, 4];

PrintArray(matrix);
FillArray(matrix);

Console.WriteLine();     //для прослойки между массивами

PrintArray(matrix);