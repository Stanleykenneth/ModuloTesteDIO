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

    [Fact]
    public void DeveVerificarSe4IsParERetornarVerdadeiro(){

         //Arrange   
         int numero = 4;

         //Act
         bool resultado = _calc.IsPar(numero);

         //Assert
         Assert.True(resultado);
    }

    // [Theory]
    // [InlineData(2)]
    // [InlineData(4)]
    // [InlineData(6)]
    // [InlineData(8)]
    // [InlineData(10)]
    // public void DeveVerificarSeOsNumerosSaoParesERetorneVerdadeiro(int numero){

    //     //Act
    //     bool resultado = _calc.IsPar(numero);

    //     //Assert
    //     Assert.True(resultado);
    // }

    [Theory]
    [InlineData(new int[] {2, 4})]
    [InlineData(new int[] {6, 8, 10})]
    public void DeveVerificarSeOsNumerosSaoParesERetorneVerdadeiro(int[] numeros){

        //Act / Assert

        // foreach(var item in numeros){

        //     Assert.True(_calc.IsPar(item));
        // }

        Assert.All(numeros, num => Assert.True(_calc.IsPar(num)));
    }
}