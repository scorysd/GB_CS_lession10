// Задача 73: Есть число N. Сколько групп M, можно получить при разбиении всех
// чисел на группы, так чтобы в одной группе все числа были взаимно просты (все
// числа в группе друг на друга не делятся)? Найдите M при заданном N и получите
// одно из разбиений на группы N ≤ 10²⁰.
Console.Clear();
Console.WriteLine("Введите количество элментов массива: ");
int[] mass = new int[Convert.ToInt32(Console.ReadLine())];
void FillArray(int[] array)
{
    array[0] = 1;
    for (int i = 1; i < array.Length; i++)
    {
        array[i] = array[i - 1] + 1;
    }
}
void PrintMass(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
void SplitForGroup(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i+1] % array[i]  == 0)
        {
            int[] mass = new int[array.Length];
            mass[i] = array[i];
            Console.WriteLine(mass[i] + " ");
        }
        break;
    }
    
}

Console.WriteLine();
FillArray(mass);
PrintMass(mass);
SplitForGroup(mass);