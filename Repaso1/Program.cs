// See https://aka.ms/new-console-template for more information

/*
Console.WriteLine("Hola a todes!");
var n = 1.1;
var square_n = 0.0;


Console.WriteLine("Introduzca valor para operar");

n = Convert.ToDouble(Console.ReadLine());
square_n = n * n;
Console.WriteLine($"El valor de {n} al cuadrado es {square_n}");

//Operadores Lógicos
bool a = true;
bool b = true;

Console.WriteLine("and");
Console.WriteLine(a && b);
Console.WriteLine("or");
Console.WriteLine(a || b);
Console.WriteLine("not");
Console.WriteLine(!a);

//Relaciones

float numA = 9.7f;
float numB = 9.7f;

Console.WriteLine($"Num A ({numA}) \t es igual que Num B ({numB})?  ");
Console.WriteLine(numA==numB);

//Entrar a un lugar para grandes
Console.WriteLine("Ingrese su año de nacimiento");
int fechaHoy = 2024;
int nacimiento = int.Parse(Console.ReadLine());

int edad = fechaHoy - nacimiento;

Console.WriteLine($"La persona puede entrar? \n {edad>17}");

//Un numero es par?
Console.WriteLine("Ingrese el numero para validar");
int numC = Convert.ToInt16(Console.ReadLine());
var par = false;

int residuo = numC % 2;
par = (residuo != 0);

Console.WriteLine($"El numero {numC} tiene paridad: {!par}");
*/

int numA = 100;
int numB = 12;

if (numA > numB)
{
    Console.WriteLine($"primero mayor que el segundo");
}
else
{
    Console.WriteLine($"segundo mayor que el primero");
    
}
Console.WriteLine($" A:{numA}\n B:{numB}");

