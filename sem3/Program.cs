// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// void getDot(int x, int y)
// {
//     if (x == 0 || y == 0)
//     {
//         Console.WriteLine("Нет возможности определить четверть");
//     }
//     else
//     {
//         if (x > 0 && y > 0)
//             Console.WriteLine("1 четверть");
//         if (x > 0 && y < 0)
//             Console.WriteLine("4 четверть");
//         if (x < 0 && y > 0)
//             Console.WriteLine("2 четверть");
//         if (x < 0 && y < 0)
//             Console.WriteLine("3 четверть");
//     }
// }

// Console.WriteLine("Введите две точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());

// getDot(x1, y1);




// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


// void getDot(int q)
// {
//     if (q <= 0 || q > 4)
//     {
//         Console.WriteLine("Нет возможности определить диапазон");
//     }
//     else
//     {
//         if (q == 1)
//             Console.WriteLine("диапазон Х > 0 и Y > 0");
//         else if (q == 2)
//             Console.WriteLine("диапазон Х > 0 и Y < 0");
//         else if (q == 3)
//             Console.WriteLine("диапазон Х < 0 и Y < 0");
//         else
//             Console.WriteLine("диапазон Х < 0 и Y > 0");
//     }
// }

// Console.WriteLine("Введите четверть: ");
// int q1 = Convert.ToInt32(Console.ReadLine());

// getDot(q1);





// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// Console.Clear();

// double distAB(int x1, int y1, int x2, int y2)
// {
//     return Math.Sqrt(Math.Pow(Math.Abs((x2 - x1)), 2) + Math.Pow(Math.Abs((y2 - y1)), 2));
// }

// Console.WriteLine("Введите координту Х1: ");
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координту Y1: ");
// int yA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координту X2: ");
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координту Y2: ");
// int yB = Convert.ToInt32(Console.ReadLine());

// double res = Math.Round(distAB(y2: yB, x1: xA, y1: yA, x2: xB), 2);

// Console.WriteLine("Длина отрезка: " + res);


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N

// Console.Clear();

// void listSqrt(int n)
// {
//     int count = 1;

//     Console.Write(n + "-> ");

//     if (n > 0)
//     {

//         while (count <= n)
//         {
//             Console.Write(Math.Pow(count, 2) + ", ");
//             count++;
//         }
//     }
//     else
//     {
//         count = -1;
//         while (count >= n)
//         {
//             Console.Write(Math.Pow(count, 2) + ", ");
//             count--;
//         }
//     }
// }

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// listSqrt(num);

// ДЗ

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// int x1 = Coordinate("x", "A");
// int y1 = Coordinate("y", "A");
// int z1 = Coordinate("z", "A");
// int x2 = Coordinate("x", "B");
// int y2 = Coordinate("y", "B");
// int z2 = Coordinate("z", "B");

// int Coordinate(string coorName, string pointName)
// {
//     Console.Write($"Введите координату {coorName} точки {pointName}: ");
//     return Convert.ToInt16(Console.ReadLine());
// }

// double Decision(double x1, double x2, 
//                 double y1, double y2, 
//                 double z1, double z2){
//   return Math.Sqrt(Math.Pow((x2-x1), 2) + 
//                    Math.Pow((y2-y1), 2) + 
//                    Math.Pow((z2-z1), 2));
// }

// double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

// Console.WriteLine($"Длина отрезка  {segmentLength}");

//  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.Write("Введите число: ");
// int cube = Convert.ToInt32(Console.ReadLine());

// void Cube(int[] cube){
//   int counter = 0;
//   int length = cube.Length;
//   while (counter <  length){
//     cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
//     counter++;
//   }
// }

// void PrintArry(int[] coll){
//   int count = coll.Length;
//   int index = 0;
//   while(index < count){
//     Console.Write(coll[index]+ " ");
//     index++;
//   }
// } 

// int[] arry = new int[cube+1];
// Cube(arry);
// PrintArry(arry);