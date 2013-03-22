using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GenericLearning
{
    public partial class Item10 : Form
    {
        public Item10()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person person1 = new Person() { Name = "Chen", Age = 30 };
            Person person2 = new Person() { Name = "Chen", Age = 30 };
            Person person3 = person1;



            bool r1 = person1.Equals(person2);
            bool r2 = object.Equals(person1, person2);
            bool r3 = object.Equals(person1, person3);
            bool r4 = person1.Equals(person3);

            bool r5 = person1 == person2;
            bool r6 = person1 != person2;

            Person student1 = new Student() { Name = "Chen", Age = 30 };

            bool r7 = object.Equals(person1, student1);
        }
    }

    public class Student : Person { }

    public class Person : IComparable<Person>, IEquatable<Person>, IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }



        #region IComparable Members
        int IComparable.CompareTo(object obj)
        {
            if (obj.GetType() != typeof(Person))
                throw new ArgumentException(
                    "Argument is not a Name object");
            return this.CompareTo(obj as Person);
        }
        #endregion

        #region IComparable<Person> Members
        public int CompareTo(Person other)
        {
            if (other == null)
                return 1; // Any non-null object > null.
            int rVal = Comparer<string>.Default.Compare
                (Name, other.Name);
            if (rVal != 0)
                return rVal;
            return Comparer<int>.Default.Compare
                (Age, other.Age);
            
        }
        #endregion

        #region IEquatable<Person> Members
        public bool Equals(Person other)
        {
            if (Object.ReferenceEquals(other, null))
                return false;
            // Semantically equivalent to using
            // EqualityComparer<string>.Default
            return Name == other.Name &&
                Age == other.Age;
        }
        #endregion

        public static bool CheckEquality<T>(T left, T right) where T : IEquatable<T>
        {
            if (left == null)
                return right == null;
            //this will use IEquatable.Equals
            return left.Equals(right);
        }

        public override bool Equals(object obj)
        {
            //Type comparison is import
            //since student with ame property values compare to person would return true in value semantics
            if (obj.GetType() == typeof(Person))
                return this.Equals(obj as Person);
            else return false;

        }
        public override int GetHashCode()
        {
            int hashCode = 0;
            if (Name != null)
                hashCode ^= Name.GetHashCode();
            if (Age != null)
                hashCode ^= Age.GetHashCode();
           
            return hashCode;
        }

        public static bool operator ==(Person left, Person right)
        {
            //if (left == null)
            //    return right == null;
            return left.Equals(right);
        }
        public static bool operator !=(Person left, Person right)
        {
            //if (left == null)
            //    return right != null;
            return !left.Equals(right);
        }

        public static bool operator <(Person left, Person right)
        {
            if (left == null)
                return right != null;
            return left.CompareTo(right) < 0;
        }
        public static bool operator >(Person left, Person right)
        {
            if (left == null)
                return false;
            return left.CompareTo(right) < 0;
        }

        public static bool operator <=(Person left, Person right)
        {
            if (left == null)
                return true;
            return left.CompareTo(right) <= 0;
        }
        public static bool operator >=(Person left, Person right)
        {
            if (left == null)
                return right == null;
            return left.CompareTo(right) >= 0;
        }




    }

}
