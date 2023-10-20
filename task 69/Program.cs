// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Exponentiation(int numA, int numB)
{
    if(numB == 0) return 1;
    return numA * Exponentiation(numA, numB-1);
    
}

Console.WriteLine("Введите натуральное число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Exponentiation(numberA, numberB);
Console.Write($"A = {numberA}, B = {numberB} -> ");
Console.WriteLine(Exponentiation(numberA,numberB));