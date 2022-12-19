namespace ThirdSublab;

public class Expert : Shooter
{
    public Expert(string name, int age, int experience) : base(name, age, experience) {}

    public override bool Shoot()
    {
        return 0.05 * experience >= new Random().NextDouble();
    }
}