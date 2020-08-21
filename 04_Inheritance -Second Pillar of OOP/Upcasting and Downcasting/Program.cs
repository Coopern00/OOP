using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Upcasting
            //Text text = new Text();
            //Shape shape = text;

            //text.Width = 200;
            //shape.Width = 100;

            //Console.WriteLine(text.Width);

            //StreamReader reader = new StreamReader(new MemoryStream());
            //var list = new ArrayList();
            //list.Add(1);
            //list.Add("Mosh");
            //list.Add(new Text());

            // Every element is going to be of type Shape
            //var anotherList = new List<Shape>();

            // Downcasting
            Shape shape = new Text();
            Text text = (Text)shape;
        }
    }
}
