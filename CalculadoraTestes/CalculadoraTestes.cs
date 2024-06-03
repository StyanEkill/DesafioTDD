using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{

    private CalculadoraImp calculadoraImp;

    public CalculadoraTestes()
    {
        calculadoraImp = new CalculadoraImp("03/06/2024");
    }

    [Fact]
    public void DeveSomar()
    {
        //Arrange
        int num1 = 1;
        int num2 = 2;

        //Act
        int result = calculadoraImp.Somar(num1,num2);

        //Assert
        Assert.Equal(3, result);

    }

    [Theory]
    [InlineData (1,2,3)]
    public void DeveSomar2(int num1, int num2, int result)
    {
        //Arrange

        //Act
        int resultCalc = calculadoraImp.Somar(num1,num2);

        //Assert
        Assert.Equal(result, resultCalc);

    }

    [Fact]
     public void DeveSubtrair()
    {
        //Arrange
        int num1 = 3;
        int num2 = 2;

        //Act
        int result = calculadoraImp.Subtrair(num1,num2);

        //Assert
        Assert.Equal(1, result);

    }

    [Theory]
    [InlineData(3,2,1)]
    [InlineData(5,4,1)]
    public void DeveSubtrair2(int num1, int num2, int result)
    {
        //Arrange

        //Act
        int resultCalc = calculadoraImp.Subtrair(num1,num2);

        //Assert
        Assert.Equal(result, resultCalc);

    }

    [Fact]
     public void DeveMultiplicar()
    {
        //Arrange
        int num1 = 3;
        int num2 = 2;

        //Act
        int result = calculadoraImp.Multiplicar(num1,num2);

        //Assert
        Assert.Equal(6, result);

    }

    [Theory]
    [InlineData(3,2,6)]
    [InlineData(5,4,20)]
    public void DeveMultiplicar2(int num1, int num2, int result)
    {
        //Arrange

        //Act
        int resultCalc = calculadoraImp.Multiplicar(num1,num2);

        //Assert
        Assert.Equal(result, resultCalc);

    }

    [Fact]
     public void TestarDivisaoPorZero()
    {
        //Assert
        Assert.Throws<DivideByZeroException>(() => calculadoraImp.Dividir(3,0));

    }

    [Fact]
     public void TestarHistorico()
    {

        calculadoraImp.Somar(1,2);
        calculadoraImp.Somar(3,4);
        calculadoraImp.Somar(5,6);

        var list = calculadoraImp.Historico();

        //Assert
        Assert.NotEmpty(list);
        Assert.Equal(3, list.Count);

    }



}