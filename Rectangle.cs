namespace AdapterDemo
{
    public class Rectangle : Shape
    {
        private int width;
        private int height;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override void Draw()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine("");
            }
        }
    }
}