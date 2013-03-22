using GenericLearning;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Declare a class instance "myBox":
            Box myBox = new Box(30.0f, 20.0f);
            //myBox.publicMethod();  //not accessible

            IPublicInterface myPublicInterface = (IPublicInterface)myBox;
            myPublicInterface.publicMethod();

            
           
            //if IMyInterface is in another lib,
            //it would not be accessable
            //IMyInterface myInterface = (IMyInterface)myBox;
            //myInterface.MyMethod();

        }
    }
}
