using System;
using System.Collections.Generic;
using System.ComponentModel;
using Calculator;
using Xunit;

namespace Calculator
{
    public class UniTest1
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]

        public void TesteSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();
            int resultadoCalculadora = calc.Somar(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]

        public void Multiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();
            int resultadoCalculadora = calc.Multiplicar(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]

        public void Dividir(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();
            int resultadoCalculadora = calc.Dividir(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]

        public void Subtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();
            int resultadoCalculadora = calc.Subtrair(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]

        public void Teste(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();
            int resultadoCalculadora = calc.Subtrair(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }
        
        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = new Calculadora();
            Assert.Throws<ArgumentException>(() => calc.Dividir(3, 0));
        }
[Fact]
public void TestarHistorico()
{
    Calculadora calc = new Calculadora();

    // Realize todas as operações
    calc.Somar(1, 2);
    calc.Multiplicar(4, 5);
    calc.Dividir(5, 5);
    calc.Subtrair(6, 2);

    // Verifique o histórico de operações
    var historico = calc.ObterHistoricoOperacoes();

    // Verifique se o histórico tem o tamanho esperado
    Assert.Equal(4, historico.Count);

    // Verifique que o histórico não está vazio
        Assert.NotEmpty(historico); 
        }
    }
}
    