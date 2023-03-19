// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

System.Console.WriteLine("Введите координаты двух точек, 6 чисел ");
double dist = 0; 
 
double Distance() 
{ 
 
    int[] arr1 = new int[3]; 
    int[] arr2 = new int[3]; 
 
    for (int i = 0; i < arr1.Length; i++) 
    { 
        arr1[i] = int.Parse(Console.ReadLine()!); 
    } 
 
    for (int j = 0; j < arr2.Length; j++) 
    { 
        arr2[j] = int.Parse(Console.ReadLine()!); 
    } 
 
    double dist = Math.Sqrt(Math.Pow((arr1[0] - arr2[0]), 2) + Math.Pow((arr1[1] - arr2[1]), 2) + Math.Pow((arr1[2] - arr2[2]), 2)); 
    return dist;}

    dist = Distance();
    System.Console.WriteLine(dist);