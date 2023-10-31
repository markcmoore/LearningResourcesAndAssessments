namespace _16_AbstractClasses
{
    public class Rectangle : Shape
    {
        public double HorizontalSides { get; set; }//added in this class
        public double VerticalSides { get; set; }//added in this class

        /// <summary>
        /// Constructor created for passthrough to base from derived class.
        /// This constructor is needed because derived classes need to 
        /// pass Name and NumSides through to Shape.
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="NumSides"></param>
        /// <returns></returns>
        public Rectangle(string Name, int NumSides) : base(Name, NumSides){}

        /// <summary>
        /// Constructor Override
        /// </summary>
        /// <returns></returns>
        public Rectangle(double HorizontalSides,double VerticalSides, string Name, int NumSides) : base(Name, NumSides)
        {
            this.HorizontalSides = HorizontalSides;
            this.VerticalSides = VerticalSides;
            this.SetArea();
        }

        protected override void SetArea()
        {
            this.Area = HorizontalSides*VerticalSides;
        }
    }
}