using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace calculos.tests
{
    public class CalculadoraTest
    {
        [Fact]
        public void Soma_DeveRetornarOValorCorreto()
        {
            Calculadora c = new Calculadora();
            var resultado = c.Soma(10, 20);
            //Verifica se o resultado é igual a 30        
            Assert.Equal(30, resultado);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void RestoDivisao_DeveRetornarZero(int value)
        {
            Calculadora c = new Calculadora();
            var resultado = c.RestoDivisao(12, value);
            //Verifica se o resto da divisão é 0
            Assert.Equal(0, resultado.resto);
        }

        [Fact]
        public void Subtracao_DeveRetornarOValorCorreto()
        {
            Calculadora c = new Calculadora();
            var resultado = c.Subtracao(20, 10);
            //Verifica se o resultado é igual a 10
            Assert.Equal(10, resultado);
        }

        [Fact]
        public void Divisao_DeveRetornarOValorCorreto()
        {
            Calculadora c = new Calculadora();
            var resultado = c.Divisao(100, 10);
            //Verifica se o resultado é igual a 10
            Assert.Equal(10, resultado);
        }

        [Fact]
        public void Multiplicao_DeveRetornarOValorCorreto()
        {
            Calculadora c = new Calculadora();
            var resultado = c.Multiplicao(5, 2);
            //Verifica se o resultado é igual a 10
            Assert.Equal(10, resultado);
        }
    }
}
