// void ShowNumber(){
//     int num = new Random().Next(10,100);
//     int firstNum = num/10;
//     int secondNum = num % 10;
//     Console.Write(num)
// }


// 1  Напишите программу

// int NumberWithoutSecDig(int Number){
//     int NewNumber =  Number / 100 * 10 + Number % 10;
//     return NewNumber;
// }
// int Number = new Random().Next(100, 1000);
// int a = NumberWithoutSecDig(Number);
// Console.WriteLine(a + " " + Number);


// 2 Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
//  Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// void MultiNum(int a, int b){
//     if(b%a ==0){
//         Console.WriteLine(b + " кратно " + a);
//     }else{
//         Console.WriteLine(b + " не кратно " + a + " остаток "+ b%a);
//     }
// }

//  Console.WriteLine("Введите последовательно два числа:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());

// MultiNum(num1,num2);

// 3 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да


// void NumDiv(int a){
//     if (a%7 ==0 && a%23 ==0){
//         Console.WriteLine(a + " Кратно 23 и 7");
//     }else{
//         Console.WriteLine(a + " не кратно 23 и 7");
//     }
// }

// Console.WriteLine("Введите число: ");

// NumDiv(Convert.ToInt32(Console.ReadLine()));


// ДЗ ниже + доп

// 4 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// void NumDiv(int a, int b){
//     if(a == b*b){
//         Console.WriteLine(a + " квадрат " + b);
//     }else{
//         Console.WriteLine(a + " не квадрат " + b);
//     }
// }

// Console.WriteLine("Введите два числа: ");
// NumDiv(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введи трёхзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine("вторая цифра этого числа : "+stringNumber[1]);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.Write("Введи число: ");
// int anyNumber = Convert.ToInt32(Console.ReadLine());
// string anyNumberText = Convert.ToString(anyNumber);
// if (anyNumberText.Length > 2){
//   Console.WriteLine("третья цифра : " + anyNumberText[2]);
// }
// else {
//   Console.WriteLine("третьей цифры нет");
// }


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


// Console.Write("Введи цифру, обозначающую день недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());

// void CheckingTheDayOfTheWeek (int dayNumber) {
//   if (dayNumber == 6 || dayNumber == 7) {
//   Console.WriteLine("выходной");
//   }
//   else if (dayNumber < 1 || dayNumber > 7) {
//     Console.WriteLine("ведите число от 1(ПН) до 7(ВСК)");
//   }
//   else Console.WriteLine("не выходной");
// }

// CheckingTheDayOfTheWeek(dayNumber);