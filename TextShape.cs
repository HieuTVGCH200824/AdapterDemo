namespace AdapterDemo
{
    public class TextShape : Shape
    {
        private Text t;

        public Text T
        {
            get { return t; }
            set { t = value; }
        }

        public TextShape()
        {
            T = new Text();
        }

        public TextShape(string content)
        {
            T = new Text(content);
        }

        public override void Draw()
        {
            t.Print();
        }
    }
}