using Figure.Abstraction;

namespace Figure.Implementation
{
    public class Circle : IFigure, ICalcSquare
    {                        
        public Circle(double radius)
        {
            if(radius < 0)
            {
                throw new ArgumentException("radius must be greater than or equal to zero");
            }

            Values = [radius];
        }

        public List<double> Values { get; }

        public double CalcSquare()
        {
            return Math.PI * Math.Pow(Values[0], 2);
        }
    }
}
