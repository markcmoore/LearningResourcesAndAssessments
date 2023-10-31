using System;

namespace _16_AbstractClasses
{
    public class Triangle : Shape
    {
        public double SideLength1 { get; set; }
        public double SideLength2 { get; set; }
        public double SideLength3 { get; set; }

        /// <summary>
        /// Override Constructor
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="NumSides"></param>
        /// <returns></returns>
        public Triangle(double SideLength1,double SideLength2, double SideLength3, string Name, int NumSides) : base(Name, NumSides)
        {
            this.SideLength1 = SideLength1;
            this.SideLength2 = SideLength2;
            this.SideLength3 = SideLength3;
            SetArea();
        }

        protected override void SetArea()
        {
            //User Herons Formula to set the area.
            double tall = (SideLength1+SideLength2+SideLength3)/2;
            this.Area = Math.Sqrt(tall*(tall-SideLength1)*(tall-SideLength2)*(tall-SideLength3));          
        }
    }
}