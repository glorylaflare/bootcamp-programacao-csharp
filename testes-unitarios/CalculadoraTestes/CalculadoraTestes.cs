namespace CalculadoraTestes;
using Calculadora.Services;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;
    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }
    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;
        //Act
        int resultado = _calc.Somar(num1, num2);
        //Assert
        Assert.Equal(15, resultado);
    }
    //Validação de multiplos valores
    [Theory]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    public void DeveVerificarSeEParERetornarTrue(int numero)
    {
        //Act
        bool resultado = _calc.VerificaPar(numero);
        //Assert
        Assert.True(resultado);
    }
    //Validação de multiplos valores com Array/Lista
    [Theory]
    //Refatorando
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void DeveVerificarSeOArrayEParERetornarTrue(int[] numeros)
    {
        //Assert
        Assert.All(numeros, (num) => Assert.True(_calc.VerificaPar(num)));
    }
}