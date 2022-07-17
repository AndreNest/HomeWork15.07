 Console.Write("Сколько числе вы хотите ввести?: ");
 int m = Convert.ToInt32(Console.ReadLine());
 int[] randomArr = new int[m];
 int numb = 0;
 for (int i = 0; i < m; i++)
 {
     Console.Write("Введите число №" + i + ":");
     randomArr[i] = Convert.ToInt32(Console.ReadLine());
     if(randomArr[i] > 0) numb++;
 }
Console.WriteLine("---------------------");
Console.WriteLine("Положительных чисел: " + numb);


