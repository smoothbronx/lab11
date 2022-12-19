using SecondSublab;

var vector = new Vectors(
    new[] { 0, 0 },
    new[] { 18, 12 },
    new[] { 10, 4 }
);

var vectorsSumCoords = vector.VectorsSumCoords();
Console.WriteLine($"Координаты вектора суммы данных векторов:\n- X: {vectorsSumCoords[0]}\n- Y: {vectorsSumCoords[1]}");