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
    }
}
