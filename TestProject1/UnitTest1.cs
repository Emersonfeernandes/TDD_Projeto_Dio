using ConsoleApp1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5, 5, 10)]
        [InlineData(3, 3, 6)]
        public void TestSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int result = calc.Somar(val1, val2);

            Assert.Equal(resultado, result);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(7, 2, 5)]
        public void TestSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int result = calc.Subtrair(val1, val2);

            Assert.Equal(resultado, result);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(3, 3, 9)]
        public void TestMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int result = calc.Multiplicar(val1, val2);

            Assert.Equal(resultado, result);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(3, 1, 3)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int result = calc.Dividir(val1, val2);

            Assert.Equal(resultado, result);
        }

        [Fact]
        public void TestDividirPorZero()
        {
            Calculadora calc = new Calculadora();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));

        }

        [Fact]
        public void TestHistorico()
        {
            Calculadora calc = new Calculadora();

            calc.Somar(5, 5);
            calc.Somar(3, 3);
            calc.Somar(2, 1);
            calc.Somar(7, 5);
            calc.Somar(6, 3);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);

        }

    }
}