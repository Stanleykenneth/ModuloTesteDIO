using Calculadora.Services;


namespace CalculadoraTestes;


public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests(){

        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5com10ERetornar15()
    {
        //Arrange - Serve para montar o cenário
        int num1 = 5;
        int num2 = 10;

        //Act - O cenário já existe, agora vamos chama-lo para fazer o que deve ser feito.
        int resultado = _calc.Somar(num1, num2);

        //Assert - Valida se o que foi passado obteve o resultado esperado.
        Assert.Equal(15, resultado);

    }   
}