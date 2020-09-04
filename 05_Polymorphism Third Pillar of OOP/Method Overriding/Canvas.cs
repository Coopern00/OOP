using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverriding
{
    public class Canvas
    {
        public void DrawSahpes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                // In runtime each class's own method will be called which is polymorphism
                shape.Draw();
            }
        }
    }
}