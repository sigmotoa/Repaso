// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hola a todes!");
var n=1.1;
var square_n=0.0;

Console.WriteLine("Introduzca valor para operar");

n=Convert.ToDouble(Console.ReadLine());
square_n = n * n;
Console.WriteLine($"El valor de {n} al cuadrado es {square_n}");