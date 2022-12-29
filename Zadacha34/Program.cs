//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
int countEven = 0;
for (int i = 0; i < array.Length; i++)

    if (array[i] % 2 == 0)
    {
        countEven = countEven + 1;
    }

Console.WriteLine("Чётных чисел: " + countEven);
