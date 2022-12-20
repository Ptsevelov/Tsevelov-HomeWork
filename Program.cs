// Задача 1

/*Console.WriteLine("Ведите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
 Console.WriteLine($"Число {num1} больше числа {num2}");

else if (num1 < num2)
Console.WriteLine($"Число {num1} меньше числа {num2}");

else
Console.WriteLine("Оба числа равны");
*/

//Задача 2

/*int max = 0;
Console.WriteLine("Ведите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if(number1 > max)
max = number1;

if(number2 > max)
max = number2;

if(number3 > max)
max = number3;

Console.WriteLine($"Максимальное число: " + max);
*/

//Задача 3

/*Console.WriteLine("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number % 2) == 0)
Console.WriteLine($"{number} - четное");

else
Console.WriteLine($"{number} - нечетное");
*/

// Задача 4

Console.Write("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());

int numb1 = 2;

if(numb > 1)
{
    while(numb1 <= numb)
    {
        Console.Write(numb1 + " ");
        numb1 = numb1 + 2;
    }
}
