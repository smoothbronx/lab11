using ThirdSublab;

const int cyclesNumber = 2;

var shooters = new Shooter[]
{
    new Newbie("Alex", 16, 1),
    new Expert("Mark", 24, 3),
    new Veteran("Daniel", 70, 36),
    new Expert("Tony", 32, 4),
    new Newbie("Charles", 27, 1),
}.ToList();

void Print(
    string textToPrint,
    ConsoleColor foreground = ConsoleColor.White,
    ConsoleColor background = ConsoleColor.Black
)
{
    Console.BackgroundColor = background;
    Console.ForegroundColor = foreground;
    Console.WriteLine(textToPrint);
    Console.ResetColor();
}

var shooterHit = false;
for (var cycleIndex = 1; cycleIndex <= cyclesNumber; cycleIndex++)
{
    Print($"\nСтрелки стреляют {cycleIndex}й раз.\n");

    foreach (var shooter in shooters)
    {
        shooterHit = shooter.Shoot();
        
        if (!shooterHit)
        {
            Print($"{shooter.name} не попадает в мишень.",  ConsoleColor.Red);
            continue;
        }

        Print($"{shooter.name} попадает в мишень.",  ConsoleColor.Green);

        if (shooters.IndexOf(shooter) != shooters.Count - 1)
            Print("Остальные не стреляют.", ConsoleColor.Yellow);

        break;
    }

    if (!shooterHit)
        Print($"\nНикто из стреляющих на {cycleIndex}ом круге не попал в мишень.");
}