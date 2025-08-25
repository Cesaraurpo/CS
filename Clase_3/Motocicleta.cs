public class Motocicleta : Vehiculo
{
    //propiedades (atributos)

    public Boolean manubrio { get; set; }

    //metodos (funciones)

    public void HacerCaballito()
    {
        Console.WriteLine("La motocicleta esta haciendo un caballito");
    }

    //Implementar el metodo abstract
    public override string Encender()
    {
        return "La motocicleta encendio con cran";
    }
    public void VerEncender()
    {
        Console.WriteLine(Encender());
    }
}