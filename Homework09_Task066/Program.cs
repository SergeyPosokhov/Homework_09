// //Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// //в промежутке от M до N.


Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int sumRec(int m, int n)
{
    if (n > m)
        return n + sumRec(m, n - 1);
    return m;
}

int sum = sumRec(m, n);
Console.WriteLine();
Console.WriteLine($"Сумма чисел от {m} до {n} равна {sum}"); 
