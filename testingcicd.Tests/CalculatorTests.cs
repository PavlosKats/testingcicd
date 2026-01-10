using CalculatorApp;

namespace testingcicd.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        #region Add Tests

        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            double a = 5;
            double b = 3;

            // Act
            double result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            // Arrange
            double a = 10;
            double b = -3;

            // Act
            double result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void Add_TwoNegativeNumbers_ReturnsNegativeSum()
        {
            // Arrange
            double a = -5;
            double b = -3;

            // Act
            double result = _calculator. Add(a, b);

            // Assert
            Assert.Equal(-8, result);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 1, 2)]
        [InlineData(-1, -1, -2)]
        [InlineData(100.5, 50.5, 151)]
        [InlineData(0.1, 0.2, 0.3)]
        public void Add_VariousInputs_ReturnsExpectedResults(double a, double b, double expected)
        {
            // Act
            double result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, result, precision: 10);
        }

        #endregion

        #region Subtract Tests

        [Fact]
        public void Subtract_TwoPositiveNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            double a = 10;
            double b = 3;

            // Act
            double result = _calculator.Subtract(a, b);

            // Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void Subtract_ResultIsNegative_ReturnsNegativeNumber()
        {
            // Arrange
            double a = 3;
            double b = 10;

            // Act
            double result = _calculator.Subtract(a, b);

            // Assert
            Assert.Equal(-7, result);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, -3, -2)]
        [InlineData(100.5, 50.5, 50)]
        public void Subtract_VariousInputs_ReturnsExpectedResults(double a, double b, double expected)
        {
            // Act
            double result = _calculator.Subtract(a, b);

            // Assert
            Assert. Equal(expected, result, precision:  10);
        }

        #endregion

        #region Multiply Tests

        [Fact]
        public void Multiply_TwoPositiveNumbers_ReturnsCorrectProduct()
        {
            // Arrange
            double a = 5;
            double b = 4;

            // Act
            double result = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(20, result);
        }

        [Fact]
        public void Multiply_ByZero_ReturnsZero()
        {
            // Arrange
            double a = 5;
            double b = 0;

            // Act
            double result = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Multiply_NegativeNumbers_ReturnsPositiveProduct()
        {
            // Arrange
            double a = -5;
            double b = -4;

            // Act
            double result = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(20, result);
        }

        [Fact]
        public void Multiply_PositiveAndNegative_ReturnsNegativeProduct()
        {
            // Arrange
            double a = 5;
            double b = -4;

            // Act
            double result = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(-20, result);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(0, 100, 0)]
        [InlineData(-2, 3, -6)]
        [InlineData(1.5, 2, 3)]
        [InlineData(0.5, 0.5, 0.25)]
        public void Multiply_VariousInputs_ReturnsExpectedResults(double a, double b, double expected)
        {
            // Act
            double result = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(expected, result, precision: 10);
        }

        #endregion

        #region Divide Tests

        [Fact]
        public void Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
        {
            // Arrange
            double a = 10;
            double b = 2;

            // Act
            double result = _calculator. Divide(a, b);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            double a = 10;
            double b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
        }

        [Fact]
        public void Divide_ByZero_ThrowsExceptionWithCorrectMessage()
        {
            // Arrange
            double a = 10;
            double b = 0;

            // Act & Assert
            var exception = Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
            Assert.Equal("Cannot divide by zero", exception.Message);
        }

        [Fact]
        public void Divide_ZeroByNumber_ReturnsZero()
        {
            // Arrange
            double a = 0;
            double b = 5;

            // Act
            double result = _calculator.Divide(a, b);

            // Assert
            Assert. Equal(0, result);
        }

        [Fact]
        public void Divide_NegativeByPositive_ReturnsNegativeQuotient()
        {
            // Arrange
            double a = -10;
            double b = 2;

            // Act
            double result = _calculator. Divide(a, b);

            // Assert
            Assert.Equal(-5, result);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(9, 3, 3)]
        [InlineData(7, 2, 3.5)]
        [InlineData(-10, 2, -5)]
        [InlineData(1, 4, 0.25)]
        public void Divide_VariousInputs_ReturnsExpectedResults(double a, double b, double expected)
        {
            // Act
            double result = _calculator.Divide(a, b);

            // Assert
            Assert.Equal(expected, result, precision: 10);
        }

        #endregion
    }
}