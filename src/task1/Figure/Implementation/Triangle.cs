using Figure.Abstraction;

namespace Figure.Implementation
{
    public class Triangle : IFigure, IRightTriangle, ICalcSquare
    {                
        public List<double> Values { get; }

        public Triangle(double[] sides)
        {
            Values = [.. sides];
            if (Values.Any(x => x <= 0) || Values.Count() != 3)
                throw new ArgumentException();
        }

        public Triangle(double a, double b, double c) 
        {
            Values = [a, b, c];
            if (Values.Any(x => x <= 0))
                throw new ArgumentException("The side of the triangle should not be zero");
        }        

        public double CalcSquare()
        {
            var perimeter = Values.Sum() / 2.0;
            var inline = (perimeter - Values[0]) * 
                (perimeter - Values[1]) * (perimeter - Values[2]);            
            return Math.Sqrt(perimeter * inline);
        }

        public bool IsRightTriangle()
        {
            var indexMax = Values.IndexOf(Values.Max());

            return Math.Pow(Values[indexMax], 2) ==
                Values.Where((elem, index) => index != indexMax).Sum(s => Math.Pow(s, 2));
        }
    }
}
