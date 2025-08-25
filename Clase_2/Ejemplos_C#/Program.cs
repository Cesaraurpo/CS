// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejemplos estructurales condicionales!");

Console.WriteLine("Estructura IF");

/* //if simple
//sintaxis
sbyte EDAD_PARAMETRO = 18;
Console.Write("ingrese su edad: ");
sbyte edad = sbyte.Parse(Console.ReadLine());
if (edad >= EDAD_PARAMETRO)
{
    //valor verdadero
    Console.WriteLine("Usted es mayor de edad");
}

//if compuesto
Console.Write("ingrese su edad: ");
sbyte edad2 = sbyte.Parse(Console.ReadLine());
if (edad2 >= EDAD_PARAMETRO) {
    //valor verdadero
    Console.WriteLine("Usted es mayor de edad");
} else {
    //valor falso
    Console.WriteLine("Usted es menor de edad");
}

//if anidado
Console.Write("ingrese su edad: ");
sbyte edad3 = sbyte.Parse(Console.ReadLine());
if (edad3 >= EDAD_PARAMETRO)
{
    //valor verdadero
    Console.WriteLine("Usted es mayor de edad");
}
else
{
    if (edad3 < 0)
    {
        Console.WriteLine("Edad no válida");
    }
    else
    {
        Console.WriteLine("Usted es menor de edad");
    }
} */

//Hombre Ideal: Cumplir con todas las condiciones
//Fiel - Dinero - Detallista - Personalidad - Responsable - Hijos - Edad - Estado Civil - Hermoso

Console.Write("Estado civil: ");
string estado_civil = Console.ReadLine();
Console.Write("Edad: ");
sbyte edad = sbyte.Parse(Console.ReadLine());
Console.Write("Responsable: ");
bool responsable = bool.Parse(Console.ReadLine());
Console.Write("Hijos: ");
string hijos = Console.ReadLine();

string PARAMETRO_ESTADO_CIVIL = "Soltero";
sbyte PARAMETRO_EDAD = 20;
bool PARAMETRO_RESPONSABLE = true;
string PARAMETRO_HIJOS = "Sin hijos";
if (estado_civil == PARAMETRO_ESTADO_CIVIL)
{
    if (edad >= PARAMETRO_EDAD)
    {
        if (responsable == PARAMETRO_RESPONSABLE)
        {
            if (hijos != PARAMETRO_HIJOS)
            {
                Console.WriteLine("Usted es el hombre ideal");
            }
            else
            {
                Console.WriteLine("Usted no es el hombre ideal, tiene hijos");
            }
        }
        else
        {
            Console.WriteLine("Usted no es el hombre ideal, no es responsable");
        }
    }
    else
    {
        Console.WriteLine("Usted no es el hombre ideal, no tiene la edad requerida");
    }
} else
{
    Console.WriteLine("Usted no es el hombre ideal, no es soltero");
}

