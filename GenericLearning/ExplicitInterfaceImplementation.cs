using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GenericLearning
{
    public partial class ExplicitInterfaceImplementation : Form
    {
        public ExplicitInterfaceImplementation()
        {
            InitializeComponent();
        }

        private void ExplicitInterfaceImplementation_Load(object sender, EventArgs e)
        {
            // Declare a class instance "myBox":
            Box myBox = new Box(30.0f, 20.0f);
            // Declare an interface instance "myDimensions":
            IDimensions myDimensions = (IDimensions)myBox;
            // Print out the dimensions of the box:
            /* The following commented lines would produce compilation 
               errors because they try to access an explicitly implemented
               interface member from a class instance:                   */
            //System.Console.WriteLine("Length: {0}", myBox.Length());
            //System.Console.WriteLine("Width: {0}", myBox.Width());
            /* Print out the dimensions of the box by calling the methods 
               from an instance of the interface:                         */
            System.Console.WriteLine("Length: {0}", myDimensions.Length());
            System.Console.WriteLine("Width: {0}", myDimensions.Width());

            //if IMyInterface is in another lib,
            //it would not be accessable
            IMyInterface myInterface = (IMyInterface)myBox;
            myInterface.MyMethod();
        }
    }

    
    public interface IPublicInterface
    {
        float publicMethod();
        
    }

    // explicit1.cs
    interface IDimensions
    {
        float Length();
        float Width();
    }

    internal interface IMyInterface
    {
        float MyMethod();

    }

    public class Box : IDimensions, IMyInterface, IPublicInterface
    {



        float IMyInterface.MyMethod()
        {
            return 1;
        }
        


        float lengthInches;
        float widthInches;

        public Box(float length, float width)
        {
            lengthInches = length;
            widthInches = width;
        }
        public float GetArea()
        {
            //not possible
            //return IDimensions(this).Length() * IDimensions.Width();
            return 1;
        }
        //public float Length()
        //{
        //    return lengthInches;
        //}
        
        //public float Width()
        //{
        //    return widthInches;
        //}
        // Explicit interface member implementation: 
        float IDimensions.Length()
        {
            return lengthInches;
        }
        // Explicit interface member implementation:
        float IDimensions.Width()
        {
            return widthInches;
        }





        float IPublicInterface.publicMethod()
        {
            return 0;
        }
    }
}
