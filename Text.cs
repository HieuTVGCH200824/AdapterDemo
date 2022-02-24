namespace AdapterDemo
{
    public class Text
    {
        private string content;

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public Text()
        {
            Content = "Default content";
        }
        public Text(string content)
        {
            Content = content;
        }

        public void Print()
        {
            for (int i = 0; i < content.Length + 2; i++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("*" + Content + "*");
            for (int i = 0; i < content.Length + 2; i++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine("");
        }
    }
}