//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

Console.Write("Введите целое число n: ");
int n = Convert.ToInt32(Console.ReadLine());

string SumRec (int n)
{
    
    if (n == 0) return "";
    return Convert.ToString(n) + " " + SumRec (n - 1);
    
}
   
Console.WriteLine();
Console.WriteLine($"{SumRec(n)}");
