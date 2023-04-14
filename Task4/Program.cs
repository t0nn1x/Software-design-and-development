using System;

class Program
{
    static void Main(string[] args)
    {
        IRenderer vectorRenderer = new VectorRenderer();
        IRenderer rasterRenderer = new RasterRenderer();

        Shape vectorCircle = new Circle(vectorRenderer);
        Shape rasterCircle = new Circle(rasterRenderer);
        Shape vectorSquare = new Square(vectorRenderer);
        Shape rasterSquare = new Square(rasterRenderer);
        Shape vectorTriangle = new Triangle(vectorRenderer);
        Shape rasterTriangle = new Triangle(rasterRenderer);

        vectorCircle.Draw();
        rasterCircle.Draw();
        vectorSquare.Draw();
        rasterSquare.Draw();
        vectorTriangle.Draw();
        rasterTriangle.Draw();
    }
}
