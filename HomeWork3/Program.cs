// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите число: ");
// string number = (Console.ReadLine());
// int dlina = number.Length;
// if (dlina == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - не является палиндромом");
//     }
// }
// else
// {
//     Console.WriteLine($"{number} - введите пятизначное число");
// }





// Задача 21
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между 
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Write("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;
double Distance = Math.Sqrt((A*A)+(B*B)+(C*C));
Console.WriteLine($"Расстояние равно: " + Distance);


// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Cube(int N){
//     int result = 1;
//     for(int curr = 1; curr <= N; curr++){
//     result = curr*curr*curr;
//     Console.Write(result + " ");
//     }
// }
// Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Cube(N);