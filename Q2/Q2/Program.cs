using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape S1 = new Shape(1,"Rectangle","Blue");
            Shape S2 = new Shape(2, "Square", "Red");
            Shape original_Shape = new Shape(3, "Triangle", "Green");
            
            //Shallow copy
            Shape Shallow_copy  = original_Shape;

            //deep copy
            Shape Deep_copy = new Shape(original_Shape);

            Console.WriteLine("->Before Changes :");
            Console.WriteLine("Original object :");
            original_Shape.Display();
            Console.WriteLine("Shallow copy:");
            Shallow_copy.Display();
            Console.WriteLine("Deep copy:");
            Deep_copy.Display();

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("\n->After changes :");
            Console.WriteLine("Original object :");
            original_Shape.ShapeID = 4;
            original_Shape.ShapeType = "Hexagon";
            original_Shape.Color = "Orange";
            original_Shape.Display();
            Console.WriteLine("Shallow copy");
            Shallow_copy.Display();
            Console.WriteLine("Deep copy");
            Deep_copy .Display();
            Console.ReadLine();
            Console.Clear();    

            Console.WriteLine("-------------------------------------------------------------------");

            Canvas C1 = new Canvas(1);
            Canvas original_canvas = new Canvas(2);
            original_canvas.ADD_shapes(S1);
            original_canvas.ADD_shapes(S2);

            //shallow copy 
            Canvas Shallow_Copy =   original_canvas;
            
            //Deep copy 
            Canvas Deep_Copy = new Canvas(original_canvas);

            Console.WriteLine("->Before Changes :");
            Console.WriteLine("Original object :");
            original_canvas.Display_all();
            Console.WriteLine("Shallow copy:");
            Shallow_Copy.Display_all();
            Console.WriteLine("Deep copy:");
            Deep_Copy.Display_all();

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("\n->After changes :");
            original_canvas.canvas_id = 12;

            Console.WriteLine("Original object :");
            original_canvas.Display_all();
            Console.WriteLine("Shallow copy");
            Shallow_Copy.Display_all();
            Console.WriteLine("Deep copy");
            Deep_Copy.Display_all();
        }
    }
}
