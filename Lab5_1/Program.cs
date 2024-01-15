namespace Lab5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle { X = 10, Y = 20, Width = 5, Height = 10 });
            shapes.Add(new Triangle { X = 5, Y = 15, Width = 6, Height = 12 });
            shapes.Add(new Rectangle { X = 7, Y = 4, Width = 3, Height = 8 });

            foreach (Shape shape in shapes)
            {
                shape.draw();
            }
        }
    }
}