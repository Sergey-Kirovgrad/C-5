//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

int[] Res(int[] diff)
{
    int max = diff[0];
    int min = diff[0];
    for (int i = 0; i < diff.Length; i++)
    {
        if (diff[i] > max)
        {
            max = diff[i];
        }
        if (diff[i] < min)
        {
            min = diff[i];
        }
    }
    Console.WriteLine($"{max}  {min}");
    return new int[] { max, min };
}