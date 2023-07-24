using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_algorithm.SCALAR.Intermediate_DSA_2
{
    public class ClassAndObject
    {
        class Circle
        {
            // Define properties here

            public int radius { get; set; }
            public double pi = 3.14;
            // Define constructor here
            public Circle(int radius)
            {
                this.radius = radius;
            }
            public float perimeter()
            {
                return (float)(2 * pi * this.radius); // Complete the function

            }

            public float area()
            {
                return (float)(pi * this.radius * this.radius);
                // Complete the function

            }
        };
        class Rectangle
        {
            // Define properties here
            public int lenght { get; set; }
            public int breadth { get; set; }

            // Define constructor here
            public Rectangle(int lengh, int brea)
            {
                this.lenght = lengh;
                this.breadth = brea;
            }

            public int perimeter()
            {
                // Complete the function
                return 2 * (this.lenght + this.breadth);
            }

            public int area()
            {
                // Complete the function
                return (this.lenght * this.breadth);

            }

        }
    }
}
