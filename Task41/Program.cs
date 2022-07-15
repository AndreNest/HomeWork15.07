// Task41
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] randomArr = new int[m];
// int numb = 0;
// for (int i = 0; i < m; i++)
// {
//     randomArr[i] = new Random().Next(-10, 11);
//     Console.Write(randomArr[i] + " ");
//     if(randomArr[i] > 0) numb++;
// }
// Console.WriteLine("---------------------");
// Console.WriteLine(numb);

Console.Write("Сколько чисел вы хотите ввести?: ");
int m = Convert.ToInt32(Console.ReadLine());
int numb = 0;
for (int i = 0; i < m; i++)
{
    int numbers = Convert.ToInt32(Console.ReadLine());
    if (numbers > 0) numb++;
}
Console.WriteLine("Количество положительных чисел " + numb);
