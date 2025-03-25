using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Shape
    {
        private int shape_ID;
        private string shape_type;
        private string color;

        //properties 
        public int ShapeID
        {
            get { return shape_ID; }
            set { shape_ID = value; }
        }
        public string ShapeType
        {
            get { return shape_type; }
            set { shape_type = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        //constructor
        public Shape(int id,string shape_type,string color)
        {
            shape_ID = id;
            this.shape_type = shape_type;
            this.color = color;
        }

        //Constructor overloading for deep copy
        public Shape(Shape other)
        {
            shape_ID = other.shape_ID;
            shape_type = other.shape_type;
            color = other.color;
        }

        public void Display()
        {
            Console.WriteLine($"Shape ID : {shape_ID} , Shape Type : {shape_type} , Shape color :{color}\n");
        }
        //Destructor
      /*  ~Shape()
        {
            Console.WriteLine($"Shape with id {shape_ID} is terminated. ");
        }
      */
    }
}
