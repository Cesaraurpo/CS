/* public interface IPayable
{
    decimal CalculatePayment();
}

public abstract class EmployeeBase : IPayable
{
    public string FullName { get; }
    protected EmployeeBase(string name) => FullName = name;
    public abstract decimal CalculatePayment();
}

public class FullTime : EmployeeBase
{
    public decimal Monthly { get; }
    public FullTime(string name, decimal monthly) : base(name) => Monthly = monthly;
    public override decimal CalculatePayment() => Monthly;
}

public class Hourly : EmployeeBase
{
    public decimal Rate { get; }
    public int Hours { get; }
    public Hourly(string name, decimal rate, int hours) : base(name) { Rate = rate; Hours = hours; }
    public override decimal CalculatePayment() => Rate * Hours;
}


var payroll = new List<IPayable>
{
    new FullTime("Ana", 4_200_000m),
    new Hourly("Luis", 60_000m, 80)
};
foreach (var p in payroll)
    Console.WriteLine($"{p.GetType().Name} -> Pago: {p.CalculatePayment():C0}");


/* Ejercicio 3
    Crea IReportable con string BuildReport().
    Implementa en FullTime y Hourly.
    Recorre List<IReportable> y muestra reportes.
    Plus: agrega TaxRate y calcula retenciones (sólo en Hourly).
 */