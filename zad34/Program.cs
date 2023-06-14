// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

 void FillArray(int[] collection)
 {
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection [index] = new Random().Next(100,1000);
        index++;
    }
 }

void PrintArray(int[] col)
{
int count = col.Length;
int position = 0;
while (position<count)
{
    Console.WriteLine(col[position]);
    position++;
}
}

int IndexOf(int[] collection)
{    
int col = 0;    
int count = collection.Length;
int index = 0;
while (index<count)
{
    if (collection[index] %2 == 0 )
    {
        col++;
    }
    index++;
}
return col;
}


int[] array = new int[5];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array);
Console.WriteLine(pos);




