int[] array = {12,12,31,4,51,6,17,18};

int n = array.Length;
int find = 12;

int index = 0;

while (index < n)
{
if(array[index] == find)
{
    Console.WriteLine(index);
}
    index++;
}