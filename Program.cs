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
