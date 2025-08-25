Console.Write("Ingrese su nombre completo: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Ingrese su edad: ");
        string inputEdad = Console.ReadLine();
        int edad;
        if (!int.TryParse(inputEdad, out edad))
        {
            Console.WriteLine("Edad no válida.");
            return;
        }

        Console.Write("Ingrese su estatura en metros (ej: 1,75): ");
        string inputEstatura = Console.ReadLine();
        double estatura;
        if (!double.TryParse(inputEstatura, out estatura) || estatura <= 0)
        {
            Console.WriteLine("Estatura no válida.");
            return;
        }

        Console.Write("Ingrese su peso en kilogramos (ej: 70): ");
        string inputPeso = Console.ReadLine();
        double peso;
        if (!double.TryParse(inputPeso, out peso) || peso <= 0)
        {
            Console.WriteLine("Peso no válido.");
            return;
        }

        double imc = peso / (estatura * estatura);

        Console.WriteLine($"\nResumen:");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Estatura: {estatura} m");
        Console.WriteLine($"Peso: {peso} kg");
        Console.WriteLine($"Su índice de masa corporal (IMC) es: {imc:F2}");