// вид 1    не принимает никаких аргументов и ничего не возвращают.

void Method1()
{
    Console.WriteLine("Автор Дарья");
}

// Method1();






// вид 2    принимает какие-то аргументы, но ничего не возвращают.

void Method2(string msg)
{
    Console.WriteLine(msg);
}

// Method2("Текст сообщения");
// Method2(msg: "Текст сообщения"); //Если несколько аргументов

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
        
}

// Method21(msg: "текст", count: 4);
// Method21(count: 4, msg: "новый текст");





// вид 3     может что-то возвращать, но не принимает никаких
// аргументов. Например, может служить для генерации случайных данных.

int Method3()
{
    return DateTime.Now.Year; 
} 

// int year = Method3(); 

// Console.WriteLine(year);







// вид 4       что-то принимает (аргументы, данные). И что-то
// возвращает для дальнейшей работы.

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
        {
        result = result + text;
        i++;
        }
    return result;
}
//    string res = Method4(10, "asdf");

//    Console.WriteLine(res);


// вид 4 с использованием цикла FOR
string Method4(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++) 
       
        {
        result = result + text;
        }
    return result;
}

string res = Method4(10, "asdf");

Console.WriteLine(res);