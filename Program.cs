/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
*/
/*
Console.Write ("Input 1st number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input 2nd number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num > num1)
{
Console.WriteLine ($"max = {num} and min = {num1}");
}
else 
{
    Console.WriteLine ($"max = {num1} and min = {num}");
}
*/


//Задача 4: Напишите программу, которая принимает на вход 
//три числа и выдаёт максимальное из этих чисел.

/*
Console.Write ("Input number 1: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input number 2: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input number 3: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max=0;
if (num > num1)
{
max = num;
}
else 
{
    max = num1;
}

if (num1 > num2)
{
max = num1;
}
else 
{
    max = num2;
}

if (num2 > num)
{
max = num2;
}
else 
{
    max = num;
}
Console.WriteLine ($"max = {max} ");
*/


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write ("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int number = num % 2;

if(number == 0)
{
    Console.WriteLine("Your number is even");
}
else
{
    Console.WriteLine("Your number is not even");
}

*/



//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int evenNum = 2;

if(num > 1)
{
    while(evenNum <= num)
    {
        Console.Write(evenNum + " ");
        evenNum = evenNum + 2;
    }
}
