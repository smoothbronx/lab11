using FirstSublab;

Console.Write("Vector start Coords 'X, Y': ");
var startCoords = Console.ReadLine()!.Split(",").Select(int.Parse).ToArray();

Console.Write("Vector end Coords 'X, Y': ");
var endCoords = Console.ReadLine()!.Split(",").Select(int.Parse).ToArray();
Console.WriteLine();

var userVector = new Vector(
    new[] { startCoords[0], startCoords[1] },
    new[] { endCoords[0], endCoords[1] });


var userVectorMiddleCoords = userVector.GetCoordsOfVectorMiddle();
Console.WriteLine($"Coords of vector middle: ({userVectorMiddleCoords[0]}, {userVectorMiddleCoords[1]})");
Console.WriteLine($"Vector corner is{(userVector.CornerIs45deg() ? " " : " not")} equal 45deg");