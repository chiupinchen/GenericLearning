using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLearning.DesignPatterns.Command
{
    public interface ICommand
    {
        void Execute(IDrawing drawing);
    }
}
