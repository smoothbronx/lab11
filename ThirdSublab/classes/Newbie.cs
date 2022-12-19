namespace ThirdSublab;

public class Newbie : Shooter
{
    public Newbie(string name, int age, int experience) : base(name, age, experience) {}

    public override bool Shoot()
    {
        return 0.01 * experience >= new Random().NextDouble();
    }
}