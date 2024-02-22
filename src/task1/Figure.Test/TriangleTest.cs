using Figure.Abstraction;
using Figure.Implementation;

namespace Figure.Test
{
    public class TriangleTest
    {
        [Theory]
        [InlineData(0, new double[] { 1, 2, 3 })]
        [InlineData(1.98, new double[] { 2, 2, 3})]
        public void GetSqueareTest(double expected, double[] sights)
        {
            ICalcSquare triangle = new Triangle(sights);
            Assert.Equal(expected, triangle.CalcSquare(), 2);
        }      

        [Theory]
        [InlineData(false, new double[] { 2, 2, 3 })]
        [InlineData(true, new double[] { 3, 4, 5 })]
        public void IsRightTriangleTest(bool expected, double[] sights)
        {
            IFigure figure = new Triangle(sights);
            if(figure is not IRightTriangle triangle)
                throw new InvalidCastException();

            Assert.Equal(expected, triangle.IsRightTriangle());
        }
    }
}
