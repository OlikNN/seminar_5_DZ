// Задайте массив натуральных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int[5];
int maxi = 0;
int mini = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Введите {i + 1} число");
    array[i] = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine(i);
}
for (int i = 0; i < 5; i++)
{
    if(array[i] > array[maxi])
    {
        maxi = i;
    }
    if(array[i] < array[mini])
    {
        mini = i;
    }
}
Console.WriteLine($"минимальный {array[mini]}");
Console.WriteLine($"максимальный {array[maxi]}");
Console.WriteLine($"сумма {array[mini] + array[maxi]}");
