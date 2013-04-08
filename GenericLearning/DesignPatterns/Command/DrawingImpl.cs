using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLearning.DesignPatterns.Command
{
    public class DrawingImpl: IDrawing
    {


        public void ProcessPixel()
        {
            Console.WriteLine("ProcessPixel");
        }

        public void ProcessShape()
        {
            Console.WriteLine("ProcessShape");
        }

        public void ProcessColor()
        {
            Console.WriteLine("ProcessColor");
        }
    }
}
