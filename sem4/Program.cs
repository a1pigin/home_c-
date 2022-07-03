// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int sumToNum(int num)
// {
// int sum = 0;
// for (int i =1;i<= num; i++)
// {
//     sum += i;
// }
// return sum;
// }

// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Sum of elements is " + sumToNum(number));




// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// int numbers = 55;
// int count = 0;
// while(numbers > 0)
// {
// numbers = numbers / 10;
// count++;
// }
// Console.WriteLine(count);

// второе решение

// int countnumbers(int num)
// {
//     int count = 0;
//     while(num > 0)


// {
//     num = num / 10;
//     count++;
// }

   
// return (count);
// }
// int numbers = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(countnumbers(numbers));

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// int miltiplayToNum(int num)
// {
//     int miltiplay = 1;
//     for (int i=1; i <=num;i++)
//     {
//         miltiplay *= i;
//     }
//     return miltiplay;
// }

// int numbers = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(miltiplayToNum(numbers));


// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// создаем массив случайных чисел, где size -- количество элементов в массиве,
//  min -- начало диапазона генерации случайных чисел, от какого генерируем, max -- до какого генерируем

// int[] CreateRandomArray(int size, int min,int max)
// {
//     int [] array = new int [size];
//     for (int i = 0; i<size;i++)
//     {
//        array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }
// // Создаем массив из чисел, которые выводим
// int[] CreateArray(int size)
// {
// int[] array = new int[size];
// for(int i = 0; i < size ; i++)
// {
//     Console.Write("Input " + i + "element: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// return array;
// }
// // выводим значения элементов массива в одну строку через пробел
// void ShowArray (int[] array)
// {
//     for(int i = 0; i< array.Length;i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// int[] myRandomArray = CreateRandomArray(8, 0, 1);
// ShowArray(myRandomArray);
// // Console.WriteLine();
// // int[] myArray = CreateArray(6);
// // ShowArray(myArray);

// ДЗ

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 
// 2, 4 -> 16

// Console.WriteLine($"\nВозведене числа A в натуральную степень B");

// int Exponentiation(int numberA, int numberB){
//   int result = 1;
//   for(int i=1; i <= numberB; i++){
//     result = result * numberA;
//   }
//     return result;
// }

//   Console.Write("Введите число A: ");
//   int numberA = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите число B: ");
//   int numberB = Convert.ToInt32(Console.ReadLine());


//   int exponentiation = Exponentiation(numberA, numberB);
//   Console.WriteLine("Ответ: " + exponentiation);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

//   int SumNumber(int numberN){
    
//     int counter = Convert.ToString(numberN).Length;
//     int advance = 0;
//     int result = 0;

//     for (int i = 0; i < counter; i++){
//       advance = numberN - numberN % 10;
//       result = result + (numberN - advance);
//       numberN = numberN / 10;
//     }
//    return result;
//   }

// int sumNumber = SumNumber(numberN);
// Console.WriteLine("Сумма цифр в числе: " + sumNumber);
