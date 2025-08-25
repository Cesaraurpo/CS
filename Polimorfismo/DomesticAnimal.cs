abstract class DomesticAnimal
{
    //Propiedades
    public string Id { get; set; }
    //public short Age { get; set; }
    short age;

    public short Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value >= 1 && value <= 5)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("Age not valid");
            }
        }
    }
    //Metodos
    public void to_run()
    {
        //return "is running";
        Console.WriteLine("is running");
    }

    public abstract string sound();

}