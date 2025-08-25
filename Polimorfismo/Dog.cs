class Dog : DomesticAnimal
{
    //implement abstract method
    public override string sound()
    {
        return "Bark";
    }
    public void view_sound_dog()
    {
        Console.WriteLine(sound());
    }
}
