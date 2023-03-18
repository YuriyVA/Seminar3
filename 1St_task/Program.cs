// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.WriteLine("Введите число: ");
string a = Console.ReadLine()!;
bool IsPalindrom(string a){
if (a.Length == 5){
    if (a[0] == a[4] && a[1] == a[3]){
    System.Console.WriteLine("number is palindrome");
    }
    else {System.Console.WriteLine("number is't palindrome");}
    }
else{Console.WriteLine("input wrong number!");
return false;}
return true;}

bool i = IsPalindrom(a);