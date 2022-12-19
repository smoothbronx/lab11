namespace ThirdSublab;

public abstract class Shooter
{
    public string name;
    protected int age;
    protected int experience;

     protected Shooter(string name, int age, int experience)
    {
        this.name = name;
        this.age = age;
        this.experience = experience;
    }

     public abstract bool Shoot();
}