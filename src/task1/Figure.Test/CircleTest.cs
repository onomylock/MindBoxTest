using Figure.Abstraction;
using Figure.Implementation;

namespace Figure.Test
{
    public class CircleTest
    {
        [Theory]
        [InlineData(10, 100 * Math.PI)]
        [InlineData(20, 400 * Math.PI)]
        [InlineData(0, 0)]        
        public void TestGetSqare(double radius, double expected)
        {
            ICalcSquare circle = new Circle(radius);
            Assert.Equal(expected, circle.CalcSquare());            
        }

        [Theory]
        [InlineData(-1.0)]
        public void TestGetExeption(double radius) 
        {
            Action action = () => { IFigure circle = new Circle(radius); };

            var ex = Record.Exception(action);

            Assert.NotNull(ex);
            Assert.IsType<ArgumentException>(ex);
        }
    }
}