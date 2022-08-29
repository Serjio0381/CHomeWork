// Задача 10: Напишите программу, которая принимает на вход трёхзначное
//  число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// void SecNum(){
//     int N;
//     Console.WriteLine("Введите трехзначное число");
//     N = Convert.ToInt32(Console.ReadLine());
//     int dec = N / 10;
//     int ed = dec % 10;
//     Console.WriteLine("Второе число равно " + ed);
// }
// SecNum();
// Переделал задачу, решенную на семинаре (




//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число: ");  // Ввод числа
// int N = Convert.ToInt32(Console.ReadLine());   // Ввод числа

// string ThirdNum = Convert.ToString(N);  // преобразуем в строку
// if (ThirdNum.Length > 2){  //условие
//     Console.WriteLine("третья цифра " + ThirdNum[2]); // выводим результат
// }
// else {
//     Console.WriteLine("третьей цифры нет"); //отрицательный результат
// }






// Задача 15: Напишите программу, которая принимает на вход 
// цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
// int day;
// Console.Write("Введите номер дня недели, проверю, может это выходной: ");
// day = Convert.ToInt32(Console.ReadLine());

// if (day == 1){
//     Console.WriteLine("Нет");
// }
// else if(day == 2){
//     Console.WriteLine("Нет");
// }
// else if(day == 3){
//     Console.WriteLine("Нет");
// }
// else if(day == 4){
//     Console.WriteLine("Нет");
// }
// else if(day == 5){
//     Console.WriteLine("Нет");
// }
// else if(day == 6){
//     Console.WriteLine("Да");
// }
// else if(day == 7){
//     Console.WriteLine("Да");
// }
// else{
//     Console.WriteLine("не соответствует условиям");
//     }
// Переделал задачу, решенную на семинаре (