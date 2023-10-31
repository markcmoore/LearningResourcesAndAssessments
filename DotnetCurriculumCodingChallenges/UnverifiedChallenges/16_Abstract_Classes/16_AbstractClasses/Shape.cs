using System;

namespace _16_AbstractClasses
{
    abstract public class Shape
    {
        public string Name { get; set; } = "";
        public int NumSides { get; set; } = 0;
        protected double area;
        protected double Area 
        { 
            get
            {
                return this.area;
            } 
            set
            {
                if(value > 0)
                    this.area = value;
            }
        }
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="NumSides"></param>
        public Shape(string Name, int NumSides)//Remember constructors aren't inherited.
        {
            this.Name = Name;
            this.NumSides = NumSides;
        }

        /// <summary>
        /// This method returns the general information abou the shape.
        /// </summary>
        public void GetInfo()
        {
            System.Console.WriteLine($"This {Name} has {NumSides} sides and an area of {Area}");
        }

        /// <summary>
        /// This method returns the area of the shape
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return this.Area;
        }
        
        /// <summary>
        /// This method sets the Area of the shape
        /// </summary>
        protected abstract void SetArea();

    }
}