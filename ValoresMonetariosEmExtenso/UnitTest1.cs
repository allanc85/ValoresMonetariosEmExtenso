using ConverterValoresMonetariosEmExtenso;
using System;
using Xunit;

namespace ValoresMonetariosEmExtenso
{
    public class UnitTest1
    {
        [Fact(DisplayName = "#1:  42,00 deve ser Quarenta e dois reais")]
        public void DeveRetornarValorInvalido4200()
        {
            var result = Program.Converter(42.00m);
            Assert.Equal("Quarenta e dois reais", result);
        }

        [Fact(DisplayName = "#2: 678,00 deve ser Seiscentos e setenta e oito reais")]
        public void DeveRetornarValorInvalido67800()
        {
            var result = Program.Converter(678.00m);
            Assert.Equal("Seiscentos e setenta e oito reais", result);
        }

        [Fact(DisplayName = "#3: -23,00 deve ser Valor inválido")]
        public void DeveRetornarValorInvalido_2300()
        {
            var result = Program.Converter(-23.00m);
            Assert.Equal("Valor Inválido", result);
        }

        [Fact(DisplayName = "#4:  13,92 deve ser Valor inválido")]
        public void DeveRetornarValorInvalido1392()
        {
            var result = Program.Converter(13.92m);
            Assert.Equal("Valor Inválido", result);
        }

        [Fact(DisplayName = "#5:1456,00 deve ser Valor inválido")]
        public void DeveRetornarValorInvalido145600()
        {
            var result = Program.Converter(1456.00m);
            Assert.Equal("Valor Inválido", result);
        }

        [Fact(DisplayName = "001.00 deve ser Um real")]
        public void DeveRetornarUm()
        {
            var result = Program.Converter(1);
            Assert.Equal("Um real", result);
        }

        [Fact(DisplayName = "002.00 deve ser Dois reais")]
        public void DeveRetornarDois()
        {
            var result = Program.Converter(2);
            Assert.Equal("Dois reais", result);
        }

        [Fact(DisplayName = "003.00 deve ser Três reais")]
        public void DeveRetornarTres()
        {
            var result = Program.Converter(3);
            Assert.Equal("Três reais", result);
        }

        [Fact(DisplayName = "007.00 deve ser Sete reais")]
        public void DeveRetornarSete()
        {
            var result = Program.Converter(7);
            Assert.Equal("Sete reais", result);
        }

        [Fact(DisplayName = "009.00 deve ser Nove reais")]
        public void DeveRetornarNove()
        {
            var result = Program.Converter(9);
            Assert.Equal("Nove reais", result);
        }

        [Fact(DisplayName = "010.00 deve ser Dez reais")]
        public void DeveRetornarDez()
        {
            var result = Program.Converter(10);
            Assert.Equal("Dez reais", result);
        }

        [Fact(DisplayName = "013.00 deve ser Treze reais")]
        public void DeveRetornarTreze()
        {
            var result = Program.Converter(13);
            Assert.Equal("Treze reais", result);
        }

        [Fact(DisplayName = "017.00 deve ser Dezessete reais")]
        public void DeveRetornarQuinze()
        {
            var result = Program.Converter(17);
            Assert.Equal("Dezessete reais", result);
        }

        [Fact(DisplayName = "021.00 deve ser Vinte e um reais")]
        public void DeveRetornarVinteUm()
        {
            var result = Program.Converter(21);
            Assert.Equal("Vinte e um reais", result);
        }

        [Fact(DisplayName = "029.00 deve ser Vinte e nove reais")]
        public void DeveRetornarVinteNove()
        {
            var result = Program.Converter(29);
            Assert.Equal("Vinte e nove reais", result);
        }

        [Fact(DisplayName = "037.00 deve ser Trinta e sete reais")]
        public void DeveRetornarTrintaSete()
        {
            var result = Program.Converter(37);
            Assert.Equal("Trinta e sete reais", result);
        }

        [Fact(DisplayName = "042.00 deve ser Quarenta e dois reais")]
        public void DeveRetornarQuarentaDois()
        {
            var result = Program.Converter(42);
            Assert.Equal("Quarenta e dois reais", result);
        }

        [Fact(DisplayName = "085.00 deve ser Oitenta e cinco reais")]
        public void DeveRetornarOitentaCinco()
        {
            var result = Program.Converter(85);
            Assert.Equal("Oitenta e cinco reais", result);
        }

        [Fact(DisplayName = "099.00 deve ser Noventa e nove reais")]
        public void DeveRetornarNoventaNove()
        {
            var result = Program.Converter(99);
            Assert.Equal("Noventa e nove reais", result);
        }

        [Fact(DisplayName = "123.00 deve ser Cento e vinte e três reais")]
        public void DeveRetornarCentoVinteTres()
        {
            var result = Program.Converter(123);
            Assert.Equal("Cento e vinte e três reais", result);
        }
    }
}
