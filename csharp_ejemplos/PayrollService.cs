/* // Violación común: servicio mezcla cálculo + consola.
// Refactor: separar responsabilidades.
public interface IPaymentCalculator { decimal Calc(IPayable e); }

public class DefaultPaymentCalculator : IPaymentCalculator
{
    public decimal Calc(IPayable e) => e.CalculatePayment();
}

public interface IOutput { void WriteLine(string text); }
public class ConsoleOutput : IOutput { public void WriteLine(string t) => Console.WriteLine(t); }

public class PayrollService
{
    private readonly IPaymentCalculator _calc;
    private readonly IOutput _out;

    public PayrollService(IPaymentCalculator calc, IOutput output)
    {
        _calc = calc; _out = output;
    }

    public void Run(IEnumerable<IPayable> items)
    {
        foreach (var it in items)
            _out.WriteLine($"{it.GetType().Name}: {_calc.Calc(it):C0}");
    }
}

/* Ejercicio 4
    Implementa FileOutput : IOutput que escriba a un .txt.
    Crea OvertimeCalculator : IPaymentCalculator que agregue horas extra a Hourly.
    Inyecta ambas en PayrollService y ejecuta.
 */
 