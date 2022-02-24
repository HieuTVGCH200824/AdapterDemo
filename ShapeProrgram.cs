using System;
using System.Collections.Generic;

namespace AdapterDemo
{
    public class ShapeProgram
    {
        private List<Shape> shapes;

        public ShapeProgram()
        {
            shapes = new List<Shape>();
        }

        public void Run()
        {
            while (true)
            {
                PrintMenu();
                int choice = GetChoice();
                DoTask(choice);
                if (choice == 0) break;
            }
        }

        private void PrintMenu()
        {
            System.Console.WriteLine("Shape drawing program");
            System.Console.WriteLine("1. Draw Line");
            System.Console.WriteLine("2. Draw Rectangle");
            System.Console.WriteLine("3. Draw Text Shape");
            System.Console.WriteLine("4. Show All Shape");
            System.Console.WriteLine("0. Exit Program");
        }

        private int GetChoice()
        {
            System.Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        private void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: Line(); break;
                case 2: Rectangle(); break;
                case 3: TextShape(); break;
                case 4: ShowShapes(); break;
                case 0: break;
                default: break;
            }
        }

        private void Line()
        {
            Console.Clear();
            System.Console.WriteLine("Draw a new line!");
            System.Console.Write("Enter line length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Line s = new Line(length);
            shapes.Add(s);
            Console.Clear();
            s.Draw();
            System.Console.WriteLine("Shape added successfully!");
        }
        private void Rectangle()
        {
            Console.Clear();
            System.Console.WriteLine("Draw a new rectangle!");
            System.Console.Write("Enter width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Rectangle s = new Rectangle(width, height);
            shapes.Add(s);
            Console.Clear();
            s.Draw();
            System.Console.WriteLine("Shape added successfully!");
        }
        private void TextShape()
        {
            Console.Clear();
            System.Console.WriteLine("Draw a new Text Shape!");
            System.Console.Write("Enter text content: ");
            string content = Console.ReadLine();

            TextShape s = new TextShape(content);
            shapes.Add(s);
            Console.Clear();
            s.Draw();
            System.Console.WriteLine("Shape added successfully!");
        }

        private void ShowShapes()
        {
            Console.Clear();
            foreach (Shape s in shapes)
            {
                s.Draw();
            }
        }


    }
}