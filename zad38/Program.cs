// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double [] array = new double[5];

void Massiv()
{ 
 for (int i =0; i< array.Length; i++)
{
    array[i]=(Math.Round(new Random().NextDouble(),2)+new Random().Next(1,100));
    Console.WriteLine(array[i]);

}
}
double Result(double[] array)
{
    double min = array[0];
    double max = array[0];
    int index = 1;
    while (index<array.Length)
    {
        if(max<array[index]) max = array[index];
        if(min>array[index]) min = array[index];
        index++;
    }
    return max-min;
}

Massiv();

Console.WriteLine(Result(array));



