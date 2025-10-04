/* public class Employee
{
    private string _document;
    public int Id { get; }
    public string FullName { get; set; } = "";
    public decimal BaseSalary { get; private set; }

    public string Document
    {
        get => _document;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Documento requerido");
            _document = value.Trim();
        }
    }

    public Employee(int id, string fullName, decimal baseSalary, string document)
    {
        if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id));
        Id = id;
        FullName = fullName;
        SetBaseSalary(baseSalary);
        Document = document;
    }

    public void SetBaseSalary(decimal amount)
    {
        if (amount < 1_000_000m) throw new ArgumentException("Salario mínimo no válido");
        BaseSalary = amount;
    }
}

/* Ejercicio 1
    Crea Product con: Id (solo lectura), Name (valida no vacío), Price (>= 0), Stock (>= 0).
    Agrega dos constructores: uno completo y otro con precio 0 por defecto.
    Crea 2 instancias en Main y muéstralas por consola.
    Criterio pedagógico: observa si validan datos en propiedades (no en la UI), y si los mensajes de error son claros.
 */
 
 using System;

public class Product
{
    // Atributos privados
    private string _name;
    private decimal _price;
    private int _stock;

    // Propiedades
    public int Id { get; }
    
    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre del producto es requerido");
            _name = value.Trim();
        }
    }

    public decimal Price
    {
        get => _price;
        set
        {
            if (value < 0)
                throw new ArgumentException("El precio no puede ser negativo");
            _price = value;
        }
    }

    public int Stock
    {
        get => _stock;
        set
        {
            if (value < 0)
                throw new ArgumentException("El stock no puede ser negativo");
            _stock = value;
        }
    }

    // Constructor completo
    public Product(int id, string name, decimal price, int stock)
    {
        if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id), "El Id debe ser mayor que cero");
        Id = id;
        Name = name;
        Price = price;
        Stock = stock;
    }

    // Constructor con precio por defecto en 0
    public Product(int id, string name, int stock) : this(id, name, 0m, stock)
    {
    }

    // Método para mostrar información
    public override string ToString()
    {
        return $"Id: {Id}, Nombre: {Name}, Precio: {Price:C}, Stock: {Stock}";
    }
}

public class Program
{
    public static void Main()
    {
        try
        {
            // Instancia con todos los datos
            var p1 = new Product(1, "Laptop", 3_500_000m, 10);

            // Instancia con precio por defecto = 0
            var p2 = new Product(2, "Mouse inalámbrico", 50);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
