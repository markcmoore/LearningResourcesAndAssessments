using System;

namespace _16_AbstractClasses
{
    public class Square : Rectangle
    {
        private double sideLength;
        public double SideLength  
        { 
            get
            {
                return sideLength;
            } 
            set
            {
                if(value > 0)
                    sideLength = value;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="HorizontalSides"></param>
        /// <param name="VerticalSides"></param>
        /// <param name="Name"></param>
        /// <param name="NumSides"></param>
        public Square(double HorizontalSides, double VerticalSides, string Name, int NumSides) : base(Name, NumSides)
        {
            this.HorizontalSides = HorizontalSides;
            this.VerticalSides = VerticalSides;
            this.SideLength = HorizontalSides;
            this.SetArea();
        }

        protected override void SetArea()
        {
            this.Area = Math.Pow(SideLength, 2);
        }
    }
}