public class Taxi : Vehiculo
{
    //propiedades (atributos)

    public int Banderazo { get; set; }
    public short NumeroPasajeros { get; set; }

    public int Taximetro(int Banderazo)
    {
        int result = 0;
        int countKm = 10;
        result = Banderazo + countKm;
        return result;
    }

    //implementar el metodo abstract
    public override string Encender()
    {
        return "El taxi encendio con llave";
    }

    public void VerEncender()
    {
        Console.WriteLine(Encender());
    }

    //metodos (funciones)

    /* public void EncenderTaximetro()
    {
        Console.WriteLine("El taximetro esta encendido");
    }
    public void ApagarTaximetro()
    {
        Console.WriteLine("El taximetro esta apagado");
    } */
}