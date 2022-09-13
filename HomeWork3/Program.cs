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