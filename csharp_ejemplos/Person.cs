/* public class Person
{
    public string FullName { get; }
    public Person(string fullName) => FullName = fullName;
    public virtual string Describe() => $"Persona: {FullName}";
}

public class EmployeeFullTime : Person
{
    public decimal Salary { get; }
    public EmployeeFullTime(string name, decimal salary) : base(name) => Salary = salary;
    public override string Describe() => $"Empleado FT: {FullName}, salario: {Salary:C0}";
}

public sealed class Contractor : Person
{
    public decimal HourRate { get; }
    public Contractor(string name, decimal hourRate) : base(name) => HourRate = hourRate;
}

/* Ejercicio 2
    Crea Manager : EmployeeFullTime con propiedad TeamSize.
    Override Describe() para incluir tamaño de equipo.
    Instancia Person, EmployeeFullTime, Manager, Contractor y llama Describe().
 */

 