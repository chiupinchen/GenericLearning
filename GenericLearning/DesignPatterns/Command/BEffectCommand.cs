using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLearning.DesignPatterns.Command
{
    public class BEffectCommand : ICommand
    {

        public void Execute(IDrawing drawing)
        {
            drawing.ProcessColor();
            drawing.ProcessShape();

        }
    }
}
