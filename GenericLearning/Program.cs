using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GenericLearning
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Item10());
            //Application.Run(new ExplicitInterfaceImplementation());
            Application.Run(new CovarianceAndContraVariance());
            
        }
    }
}
