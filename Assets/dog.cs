
public class pet
{
    private string Breed;

    public void SetBreed(string type)
    {
        Breed = type;
    }
    public string getBreed()
    {
        return Breed;
    }
    public string whatIsIt()
    {
        return null;
    }
}
public class Dog : pet
{
    public string name;
    public Dog(string name, string breed)
    {
        this.SetBreed(breed);
        this.name = name;
    }
    public string whatIsIt()
    {
        return "It's a CAT?!";
    }

}
public class Cat : pet
{
    public string name;
    public Cat(string name, string breed)
    {
        this.SetBreed(breed);
        this.name = name;
    }
    public string whatIsIt()
    {
        return "It's a CAT?!";
    }

}
