using lab7_calc.MyCalculator;
using lab7_calc;

namespace lab7_calc.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Calculator calculator = new Calculator();

            double result = calculator.Sum("2", "2");

            Assert.Equal(4, result);
        }

        [Fact]
        public void Test2()
        {
            Calculator calculator = new Calculator();

            double result = calculator.Res("4", "2");

            Assert.Equal(2, result);
        }

        [Fact]
        public void Test3()
        {
            Calculator calculator = new Calculator();

            double result = calculator.Mul("3", "3");

            Assert.Equal(9, result);
        }

        [Fact]
        public void Test4()
        {
            Calculator calculator = new Calculator();

            double result = calculator.Div("4", "4");

            Assert.Equal(1, result);
        }

        [Fact]
        public void Test5()
        {
            Calculator calculator = new Calculator();

            var ex = Assert.Throws<Exception>(() => calculator.Sum("hello", "5"));

            Assert.Equal(ex.Message, "invalid operators");
        }

        [Fact]
        public void Test6()
        {
            Calculator calculator = new Calculator();

            var ex = Assert.Throws<Exception>(() => calculator.Res("hello", "5"));

            Assert.Equal(ex.Message, "invalid operators");
        }

        [Fact]
        public void Test7()
        {
            Calculator calculator = new Calculator();

            var ex = Assert.Throws<Exception>(() => calculator.Mul("hello", "5"));

            Assert.Equal(ex.Message, "invalid operators");
        }


        [Fact]
        public void Test8()
        {
            Calculator calculator = new Calculator();

            var ex = Assert.Throws<Exception>(() => calculator.Div("hello", "5"));

            Assert.Equal(ex.Message, "invalid operators");
        }

        [Fact]
        public void Test9()
        {
            string result = Program.Sum("2", "4", "");
            result = Program.Sum("", "2", result);

            Assert.Equal("8", result);
        }

        [Fact]
        public void Test10()
        {
            string result = Program.Res("2", "4", "");
            result = Program.Res("", "2", result);

            Assert.Equal("-4", result);
        }

        [Fact]
        public void Test11()
        {
            string result = Program.Mul("2", "4", "");
            result = Program.Mul("", "2", result);

            Assert.Equal("16", result);
        }

        [Fact]
        public void Test12()
        {
            string result = Program.Div("8", "2", "");
            result = Program.Div("", "2", result);

            Assert.Equal("2", result);
        }

    }
}