// // Написать программу которая на вход принимет число и возводит его в квадрат
// Console.WriteLine("inpun intenger number:");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num* num;
// Console.WriteLine("result is "+ result);



//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// Console.Write("input first number:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("inpun sekond number:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1== num2*num2){
//     Console.Write("first number is a square of second number");
// }
// else{
//     Console.Write("first number is not a square of second number");
// }



//Напишите программу, которая будет выдавать название дня недели по заданному номеру.

// Console.Write("input number of day:");
// int day = Convert.ToInt32(Console.ReadLine());
// if (day<1||day>7){
//     Console.Write("incorent day:");
// }
// else{
// if (day==1){
// Console.Write("monday:");
// }
// if (day==2){
// Console.Write("tusday:");
// }
// }
// ДОДЕЛАТЬ ДНИ 3-7



// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// Console.Write("input N:");
// int num = Convert.ToInt32(Console.ReadLine());

// int current;
// if (num <0){
//     current = num;
//     num= num*(-1);
// }
// else{
//     current = -1 * num;
// }

// while(current < num-1){
//     current++;
//     Console.Write(current + " ");
// }



// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// поэксперементировать с 100 1000 double num % 10

// Console.Write("input N:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write(num % 10);



// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Введите num1:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите num2:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2){
//     Console.WriteLine($"{num1} больше");
//     Console.WriteLine($"{num2} меньше");
// }

// else{
//      Console.WriteLine($"{num2} больше");
//     Console.WriteLine($"{num1} меньше");
// }



// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите первое число:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число:");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = Math.Max(a, Math.Max(b, c));

// Console.WriteLine($"Максимальное значение {max}");



// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Введите число : ");
// int a = Convert.ToInt32(Console.Read());
// if (a % 2 == 0) Console.WriteLine("Четное");
// else Console.WriteLine("Нечетное");



// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
    
// for (int i = 1; i <= n; i++)
// if (i % 2 == 0) Console.Write(i + " ");
