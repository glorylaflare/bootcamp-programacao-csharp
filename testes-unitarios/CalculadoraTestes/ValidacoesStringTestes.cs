namespace CalculadoraTestes;
using Calculadora.Services;

public class ValidacoesStringTestes
{
    private ValidacoesString _validacoes;
    public ValidacoesStringTestes()
    {
        _validacoes = new ValidacoesString();
    }
    [Fact]
    public void DeveContar3CaracteresEmOlaERetornar3()
    {
        //Arrange
        string texto = "ola";
        //Act
        int resultado = _validacoes.ContarCaracteres(texto);
        //Assert
        Assert.Equal(3, resultado);
    }
}