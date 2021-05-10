using System;

// Create a class named 'Shape' with a method to print "This is shape". Then create two other classes 
           //named 'Rectangle', 'Circle' inheriting the Shape class, both having a method to print "This is rectangular shape" 
           //and "This is circular shape" respectively. Create a subclass 'Square' of 'Rectangle' having a method to print "Square is a rectangle". 
           //Now call the method of 'Shape' and 'Rectangle' class by the object of 'Square' class
    public class shape
    {
        public void print ()
        {
            Console.WriteLine("This is shape");
        }
    }

    public class rectangle: shape 
    {
        public void printRectangle()
        {
            Console.WriteLine("This is a rectangular shape");
        }
    }
     public class circle: shape 
    {
        public void printCircle()
        {
            Console.WriteLine("This is a circular shape");
        }
    }
     public class square: rectangle 
    {
        public void printSquare()
        {
            Console.WriteLine("square is a rectangle");
        }
    }

