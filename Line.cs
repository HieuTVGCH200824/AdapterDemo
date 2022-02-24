namespace AdapterDemo
{
    public class Line : Shape
    {
        private int length;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public Line()
        {
            Length = 0;
        }

        public Line(int length)
        {
            Length = length;
        }

        public override void Draw()
        {
            for (int i = 0; i < Length; i++)
            {
                System.Console.Write("-");
            }
            System.Console.WriteLine("");
        }
    }
}