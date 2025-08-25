// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//programacion estructutada
//ejemplos manejo de variables

//sintaxis de variables
//tipoDatoAlmacenar nombreVariable = valor;
//tipos de datos primitivos
int edad = 30;
Console.WriteLine($"Edad: {edad}");
char inicial = 'J';
Console.WriteLine($"Inicial: {inicial}");
string nombre = "Juan";
Console.WriteLine($"Nombre: {nombre}");
//tipos de datos de fecha
DateTime fechaNacimiento = new DateTime(1993, 5, 15);
DateOnly fechaSolo = new DateOnly(1993, 5, 15);
Console.WriteLine($"Fecha de Nacimiento (DateOnly): {fechaSolo}");
Console.WriteLine($"Fecha de Nacimiento: {fechaNacimiento.ToShortDateString()}");
//booleano
bool esEstudiante = true;
Console.WriteLine($"Es Estudiante: {esEstudiante}");
//tipos de datos numericos
double altura = 1.75; // en metros
Console.WriteLine($"Altura: {altura}");
decimal salario = 50000.50m; // en formato decimal para mayor precisión
Console.WriteLine($"Salario: {salario}");
double peso = 70.5; // en kilogramos
Console.WriteLine($"Peso: {peso}");

//operaciones con variables
int suma = edad + 5;
Console.WriteLine($"Suma de Edad + 5: {suma}");

//sumar enteros
int numero1 = 10;
int numero2 = 20;
int resultadoSuma = numero1 + numero2;
Console.WriteLine($"Resultado de la suma: {resultadoSuma}");

//ejemplo sumar dos numeros
Console.WriteLine("Ingrese el primer número:");
int numeroA = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número:");
int numeroB = Convert.ToInt32(Console.ReadLine());
int resultadoSuma2 = numeroA + numeroB;
Console.WriteLine($"Resultado de la suma: {resultadoSuma2}");

//conversiones de tipos
string edadComoString = edad.ToString();

//tipos de datos complejos
//object persona = new { Nombre = "Juan", Edad = 30 };

//estructura de decision if simple
if (edad >= 18)
{
    Console.WriteLine("Eres mayor de edad.");
}

// estructura de decision if compiuesto
/* if (edad >= EDAD)
{
    Console.WriteLine("Eres mayor de edad y eres estudiante")
}
else
{
    Console.WriteLine("Eres menor de edad.");
}

//estructura de decision if anidada
if (edad >= 18)
{
    Console.WriteLine("Eres mayor de edad.");
    if (esEstudiante)
    {
        Console.WriteLine("Eres estudiante.");
    }
}
else
{
    Console.WriteLine("Eres menor de edad.");
} */