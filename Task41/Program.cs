/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
Console.Clear();
Console.Write("Введите число M, чтобы выдать количество цифр M от -100 до 100: ");
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int j = 0; j < count; j++)
    {
        Console.Write($"{array[j]}, ");
    } 

}
void AboveZero(int[] array) // метод считает колличество чисел в массиве выше 0.
{
    int count = array.Length;
    int temp = 0;
    for (int j = 0; j < count; j++)
    {
       if (array[j] > 0) {temp++;}
    } 
    Console.WriteLine($"Колличество чисел выше нуля: {temp}");
}
int n;
n = int.Parse(Console.ReadLine());
int[] mass = new int[n];
Random rand = new Random();
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = rand.Next(-100, 100);
}
PrintArray(mass);
Console.WriteLine();
AboveZero(mass);