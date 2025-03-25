using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Canvas
    {
        private int Canvas_ID;
        private Shape[] shapes;
        private int Shape_count;

        public int canvas_id
        {
            
            set { Canvas_ID = value; }
            get { return Canvas_ID; }
        }
        public Canvas(int canvas_id)
        {
            Canvas_ID = canvas_id;
            shapes = new Shape[10];
            Shape_count = 0;
        }
        //overloading of constructor

        public Canvas(Canvas other)
        {
            canvas_id = other.canvas_id;
            Shape_count = other.Shape_count;
            shapes= new Shape[10];
            for (int i = 0; i < Shape_count; i++)
            {
                shapes[i] =other.shapes[i];
            }
        }

            //methods
          public void ADD_shapes(Shape shape) {
            if (Shape_count < shapes.Length)
            {
                shapes[Shape_count++] = shape;
            }
            else
            {
                Console.WriteLine($"List is full.");
            }
        }
        public void Display_all()
        {
            for (int i = 0; i < Shape_count; i++)
            {
                shapes[i].Display();
            }
        }
      /*  ~Canvas()
        {
            Console.WriteLine($"Object of canvas id {Canvas_ID} is killed");
        }*/
    }
}
