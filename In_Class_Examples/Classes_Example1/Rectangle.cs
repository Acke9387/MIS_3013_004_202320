using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Example1
{
    public class Rectangle
    {

        /// <summary>
        /// The Length of the Rectangle
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// The Width of the Rectangle
        /// </summary>
        public double Width { get; set; }

        private string Name;

        /// <summary>
        /// Empty/Default Constructor
        /// </summary>
        public Rectangle()
        {
            Length = 0;
            Width = 0;
            Name = string.Empty;
        }

        public double CalculateArea()
        {
            double A = Length * Width;
            return A;
        }

        /// <summary>
        /// Calculates the Perimeter of the given Rectangle
        /// </summary>
        /// <returns>The perimeter of the rectangle</returns>
        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }

    }
}
