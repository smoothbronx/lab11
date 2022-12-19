namespace ThirdSublab;

public class Veteran : Shooter
{
    public Veteran(string name, int age, int experience) : base(name, age, experience) {}

    public override bool Shoot()
    {
        return 0.9 - 0.01 * age >= new Random().NextDouble();
    }
}