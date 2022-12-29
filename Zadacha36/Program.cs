//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
int[] array = new int[20];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write(array[i] + " ");
    }
Console.WriteLine();
//int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };

int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        sum = sum + array[i];
    }
}
Console.WriteLine(sum);