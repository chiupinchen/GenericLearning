using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLearning.DesignPatterns.Command
{
    public class Service
    {

        public void doService()
        {
            IDrawing drawing = new DrawingImpl();
            ICommand command = new AEffectCommand();

            command.Execute(drawing);

            ICommand command2 = new BEffectCommand();
            command2.Execute(drawing);

        }
    }
}
