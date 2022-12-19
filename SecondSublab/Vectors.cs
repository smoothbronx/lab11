namespace SecondSublab;
using FirstSublab;

public class Vectors : Vector
{
    private int endX2Coord;
    private int endY2Coord;
    
    public Vectors(
        int startXCoord, int startYCoord,
        int endX1Coord, int endY1Coord,
        int endX2Coord, int endY2Coord) : base(startXCoord, startYCoord, endX1Coord, endY1Coord)
    {
        this.endX2Coord = endX2Coord;
        this.endY2Coord = endY2Coord;
    }

    public Vectors(int[] startCoords, int[] endCoords, int[] end2Coords) : base(startCoords, endCoords)
    {
        if (end2Coords.Length != 2) throw new Exception("end2Coords must contain two coordinates");
        
        endX2Coord = end2Coords[0];
        endY2Coord = end2Coords[1];
    }

    public int[] VectorsSumCoords()
    {
        return new[]
        {
            endXCoord + endX2Coord - startXCoord * 2,
            endYCoord + endY2Coord - startYCoord * 2
        };
    }
}