﻿// See https://aka.ms/new-console-template for more information

/*
 *
 * Las cosas básicas de programar.

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


/*
 *
 *Ejemplo del uso de If
 *
 *
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
*/

/*
*
 *Usando un while
 *
int dato = 19;

while (true)
{
    Console.WriteLine("Ingrese su edad");
    dato = Convert.ToInt16(Console.ReadLine());

    dato++;

    Console.WriteLine(dato);
}

*/

//Crear un validador para ingresar a un bar
//Entran mayores de 18.
//Cuando sea menor, lo manda a la casa
//Pide el dato de la siguiente persona
//Aforo maximo de 10 personas


/*
int aforo = 0;
while (aforo<=10)
{
    int edad;
    Console.WriteLine("Ingrese su edad");
    edad = Convert.ToInt16(Console.ReadLine());

    if (edad>=18)
    {
        aforo = aforo + 1;
        Console.WriteLine($"Bienvenido, tu numero en el bar es: {aforo}");
    }
    else
    {
        Console.WriteLine("Chao baby");
    }

    Console.WriteLine($"El aforo hasta el momento es de: {aforo}");
}
*/


/*
var edad = 0;
do
{
    Console.WriteLine("Hola");
    Console.WriteLine("Ingrese su edad");
    edad = Convert.ToInt16(Console.ReadLine());
} while (edad <= 20);*/

//FOR

/*
for (int aforo = 0; aforo < 5; aforo++)
{
    Console.WriteLine("Quieres entrar al bar?");
    bool ingresar=Convert.ToBoolean(Console.ReadLine());
    if (ingresar == false)
    {
        aforo = aforo - 1;
    }
    Console.WriteLine(aforo);
}
*/

Console.WriteLine("Ingrese su edad");

int edad = int.Parse(Console.ReadLine());

switch (edad)
{
    case 10:
        Console.WriteLine("Para la casa");
        break;
    case 20:
        Console.WriteLine("Gasta mucho en nuestro bar");
        break;
    case 90:
        Console.WriteLine("Estas muy cuchis");
        break;
    default:
        Console.WriteLine("No estas en nuestros registros");
        break;
}

//Recibir por consola el signo del zodiaco e
//indicar en la salida, los posibles meses de cumpleaños.
//Usar Switch case























