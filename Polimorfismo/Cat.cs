class Cat : DomesticAnimal
{
    //implement abstract method
    public override string sound()
    {
        return "Meow";
    }
    public void view_sound_cat()
    {
        Console.WriteLine(sound());
    }
}
