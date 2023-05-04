// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите значение xА: ");
int xA = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Введите значение yA: ");
int yA = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Введите значение zA: ");
int zA = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Введите значение xB: ");
int xB = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Введите значение yB: ");
int yB = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Введите значение zB: ");
int zB = Convert.ToInt32(System.Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));

System.Console.WriteLine(Math.Round(distance, 2));