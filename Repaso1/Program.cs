// See https://aka.ms/new-console-template for more information

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

/*
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
*/

//Recibir por consola el signo del zodiaco e
//indicar en la salida, los posibles meses de cumpleaños.
//Usar Switch case


//Crear un menu que se muestre al iniciar y de la opción al usuario 
//de poder conocer sus posibles meses de cumpleaños segun signo
//Otra opcion sera validar si un numero es impar
//Otra opcion sera Validar la edad segun su año de nacimiento


using System.Security.Principal;

/*
string[] countries;
int[] population;

countries = new[] { "CO", "CA", "MX", "PE", "ES", "VE","GE" };
population = new[] { 50, 40, 120, 28, 30, 40, 25 };


for (int i=0; i<countries.Length; i++)
{
Console.WriteLine($"{countries[i]}" +
                  $" has a population near of:" +
                  $" {population[i]} Million person");
}

Console.WriteLine($"In {countries[3]} are {population[3]}");
*/


//Con tres arrays va a crear un menu de una tienda
//el primero tiene los productos
//El segundo los precios
//El tercero la disponibilidad (true/false)
//Imprime el menu completo


/*int[] units = new[] { 10, 20, 3, 25, 3, 17 };
float[] prices = new[] { 2.5f, 4.1f, 20.0f, 31.4f, 19, 03f, 10.3f };
string[] names = new[] { "a", "b", "c", "d", "e", "f" };

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"El producto {names[i]}," +
                      $" tiene {units[i]} y cada una " +
                      $"cuesta {prices[i]} si compra todas las unidades," +
                      $"le cuesta {prices[i]*units[i]}");
}*/

//Listas
/*List<string> countries = new List<string>();
countries.Add("CO");
countries.Add("MX");
countries.Add("PE");
countries.Add("PE");
countries.Add("PE");
countries.Add("PE");
countries.Add("VE");
countries.Add("CA");

Console.WriteLine(countries.Count());
//Console.WriteLine(countries.FindIndex(0,4,"MX"));
Console.WriteLine(countries.IndexOf("MX"));

countries.RemoveRange(1,3);
Console.WriteLine(countries.Remove("Pe"));

countries.Remove(Console.ReadLine());

Console.WriteLine(countries.Count());
/*tring country;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ingrese su pais");
    country = Console.ReadLine();
    countries.Add(country);
}
#1#



foreach (var pais in countries)
{
    Console.WriteLine(pais);
}

//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/

//https://learn.microsoft.com/en-us/dotnet/csharp/how-to/*/

//Funciones

//No recibe, no retorna
//f1();

void f1()
{
    Console.WriteLine("Gracias por llamar a f1");
}

//f1();

//No recibe, retorna


/*
List<float> calificaciones = new List<float>();

float f2()
{
    Console.WriteLine("Ingrese su nota del corte");
    float nota1 = Convert.ToInt32(Console.ReadLine());
    return (nota1 * 35) / 100;
}

for (int i = 0; i < 3; i++)
{
    calificaciones.Add(f2());
}

float total = 0f;
foreach (var nota in calificaciones)
{
    Console.WriteLine(nota);
    total = total + nota;
}

Console.WriteLine(total);*/


//Recibe y retorna

/*
bool f3(int a)
{

    if (2024 - a < 18)
    {
        return false;
    }
    else
    {
        return true;
    }

}

Console.WriteLine("Ingresa tu año de nacimiento");
int nacimiento = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(f3(nacimiento));
*/
//Recibe No retorna

List<bool> agree = new List<bool>();

void f4(bool a)
{
    agree.Add(a);
}

Console.WriteLine("Cuantos valores va a ingresar?");
int valores = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < valores; i++)
{
    Console.WriteLine("Ingrese un valor para la lista");
    f4(Convert.ToBoolean(Console.ReadLine()));
}