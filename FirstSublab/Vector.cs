namespace FirstSublab;

public class Vector
{
    private int startXCoord;
    private int startYCoord;
    private int endXCoord;
    private int endYCoord;

    public Vector(int startXCoord, int startYCoord, int endXCoord, int endYCoord)
    {
        this.startXCoord = startXCoord;
        this.startYCoord = startYCoord;
        this.endXCoord = endXCoord;
        this.endYCoord = endYCoord;
    }

    public Vector(int[] startCoords, int[] endCoords)
    {
        if (startCoords.Length != 2) throw new Exception("startCoords must contain two coordinates");
        if (endCoords.Length != 2) throw new Exception("endCoords must contain two coordinates");

        startXCoord = startCoords[0];
        startYCoord = startCoords[1];
        endXCoord = endCoords[0];
        endYCoord = endCoords[1];
    }

    public void SetStartCoords(int xCoord, int yCoord)
    {
        startXCoord = xCoord;
        startYCoord = yCoord;
    }
    
    public void SetEndCoords(int xCoord, int yCoord)
    {
        endXCoord = xCoord;
        endYCoord = yCoord;
    }

    public double[] GetCoordsOfVectorMiddle()
    {
        return new[]
        {
            (double) (startXCoord + endXCoord) / 2,
            (double) (startYCoord + endYCoord) / 2,
        };
    }

    public bool CornerIs45deg()
    {
        return Math.Abs(endXCoord - startXCoord) - Math.Abs(endYCoord - startYCoord) == 0;
    }
}