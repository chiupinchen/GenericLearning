using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GenericLearning
{
    public partial class CovarianceAndContraVariance : Form
    {
        public CovarianceAndContraVariance()
        {
            InitializeComponent();
        }

        private void CovarianceAndContraVariance_Load(object sender, EventArgs e)
        {
            
            //normal operation
            IEnumerable<Animal> animals1 = new List<Animal>() { new Animal(), new Animal()};

            //covariance //put more derived type as output type 
            //Tiger is animal
            IEnumerable<Animal> animals2 = new List<Tiger>() { new Tiger(), new Tiger()};



            //normal operation
            SortedSet<Circle> circles1 = new SortedSet<Circle>(new CircleComparer());

            //cotravariance //put less derived type as input parameters 
            //Circle is a Shape
            //if not Circle comparer, we should be able to use sharpComparer to do comparison
            SortedSet<Circle> circles2 = new SortedSet<Circle>(new ShapeComparer());
        }
    }


    

    public class Animal
    {
        public void Move()
        {
          
        }
    }

    public class Tiger : Animal { 
    }


    class Shape {
        public virtual double Area { get { return 0; } }
    }

    class Circle : Shape {

        public double r { get; set; }
        public override double Area
        {
            get
            {
                return Math.PI * r * r;
            }
        }
    }

    class CircleComparer : IComparer<Circle>
    {
        public int Compare(Circle x, Circle y)
        {
            throw new NotImplementedException();
        }
    }

    class ShapeComparer : IComparer<Shape>
    {


        public int Compare(Shape x, Shape y)
        {
            throw new NotImplementedException();
        }
    }


}
