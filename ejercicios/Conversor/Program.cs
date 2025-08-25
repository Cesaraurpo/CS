using System;
using System.Globalization;
Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Ingrese la cantidad en pesos colombianos (COP): ");
        string inputCOP = Console.ReadLine();
        double cantidadCOP;

        if (!double.TryParse(inputCOP, out cantidadCOP) || cantidadCOP <= 0)
        {
            Console.WriteLine("Cantidad en COP no válida.");
            return;
        }

        double tasaUSD = 3900.0;
        double tasaEUR = 4200.0;
        double tasaGBP = 5000.0;

        double enUSD = cantidadCOP / tasaUSD;
        double enEUR = cantidadCOP / tasaEUR;
        double enGBP = cantidadCOP / tasaGBP;

        Console.WriteLine($"\nHola {nombre}, aquí está la conversión de {cantidadCOP:C0} COP:");
        Console.WriteLine($"Dólares (USD): {enUSD.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))}");
        Console.WriteLine($"Euros (EUR): {enEUR.ToString("C2", CultureInfo.CreateSpecificCulture("fr-FR"))}");
        Console.WriteLine($"Libras Esterlinas (GBP): {enGBP.ToString("C2", CultureInfo.CreateSpecificCulture("en-GB"))}");