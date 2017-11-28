using ConverterValoresMonetariosEmExtenso;
using System;
using Xunit;

namespace ValoresMonetariosEmExtenso
{
    public class TestesNumerosPositivosInteirosAte999
    {
        [Fact(DisplayName = "#1:  42,00 deve ser Quarenta e dois reais")]
        public void DeveRetornarQuarentaDois()
        {
            var result = Program.ConverterInteiroPositivo(42.00m);
            Assert.Equal("Quarenta e dois reais", result);
        }

        [Fact(DisplayName = "#2: 678,00 deve ser Seiscentos e setenta e oito reais")]
        public void DeveRetornarSeiscentosSetentaOito()
        {
            var result = Program.ConverterInteiroPositivo(678.00m);
            Assert.Equal("Seiscentos e setenta e oito reais", result);
        }

        [Fact(DisplayName = "#3: -23,00 deve ser Valor inválido")]
        public void DeveRetornarVinteTresNegativo()
        {
            var result = Program.ConverterInteiroPositivo(-23.00m);
            Assert.Equal("Valor Inválido", result);
        }

        [Fact(DisplayName = "#4:  13,92 deve ser Valor inválido")]
        public void DeveRetornarTrezeReaisNoventaDoisCentavos()
        {
            var result = Program.ConverterInteiroPositivo(13.92m);
            Assert.Equal("Valor Inválido", result);
        }

        [Fact(DisplayName = "#5:1456,00 deve ser Valor inválido")]
        public void DeveRetornarMilQuatrocentosCinquentaSeis()
        {
            var result = Program.ConverterInteiroPositivo(1456.00m);
            Assert.Equal("Valor Inválido", result);
        }

        [Fact(DisplayName = "-0.57 deve ser Valor Inválido")]
        public void DeveRetornarCinquentaSeteCentavosNegativo()
        {
            var result = Program.ConverterInteiroPositivo(-0.57m);
            Assert.Equal("Valor Inválido", result);
        }

        [Fact(DisplayName = "-0.93 deve ser Valor Inválido")]
        public void DeveRetornarNoventaTresCentavosNegativo()
        {
            var result = Program.ConverterInteiroPositivo(-0.93m);
            Assert.Equal("Valor Inválido", result);
        }

        [Fact(DisplayName = "001.00 deve ser Um real")]
        public void DeveRetornarUm()
        {
            var result = Program.ConverterInteiroPositivo(1);
            Assert.Equal("Um real", result);
        }

        [Fact(DisplayName = "002.00 deve ser Dois reais")]
        public void DeveRetornarDois()
        {
            var result = Program.ConverterInteiroPositivo(2);
            Assert.Equal("Dois reais", result);
        }

        [Fact(DisplayName = "003.00 deve ser Três reais")]
        public void DeveRetornarTres()
        {
            var result = Program.ConverterInteiroPositivo(3);
            Assert.Equal("Três reais", result);
        }

        [Fact(DisplayName = "007.00 deve ser Sete reais")]
        public void DeveRetornarSete()
        {
            var result = Program.ConverterInteiroPositivo(7);
            Assert.Equal("Sete reais", result);
        }

        [Fact(DisplayName = "009.00 deve ser Nove reais")]
        public void DeveRetornarNove()
        {
            var result = Program.ConverterInteiroPositivo(9);
            Assert.Equal("Nove reais", result);
        }

        [Fact(DisplayName = "010.00 deve ser Dez reais")]
        public void DeveRetornarDez()
        {
            var result = Program.ConverterInteiroPositivo(10);
            Assert.Equal("Dez reais", result);
        }

        [Fact(DisplayName = "013.00 deve ser Treze reais")]
        public void DeveRetornarTreze()
        {
            var result = Program.ConverterInteiroPositivo(13);
            Assert.Equal("Treze reais", result);
        }

        [Fact(DisplayName = "017.00 deve ser Dezessete reais")]
        public void DeveRetornarQuinze()
        {
            var result = Program.ConverterInteiroPositivo(17);
            Assert.Equal("Dezessete reais", result);
        }

        [Fact(DisplayName = "021.00 deve ser Vinte e um reais")]
        public void DeveRetornarVinteUm()
        {
            var result = Program.ConverterInteiroPositivo(21);
            Assert.Equal("Vinte e um reais", result);
        }

        [Fact(DisplayName = "029.00 deve ser Vinte e nove reais")]
        public void DeveRetornarVinteNove()
        {
            var result = Program.ConverterInteiroPositivo(29);
            Assert.Equal("Vinte e nove reais", result);
        }

        [Fact(DisplayName = "037.00 deve ser Trinta e sete reais")]
        public void DeveRetornarTrintaSete()
        {
            var result = Program.ConverterInteiroPositivo(37);
            Assert.Equal("Trinta e sete reais", result);
        }

        [Fact(DisplayName = "085.00 deve ser Oitenta e cinco reais")]
        public void DeveRetornarOitentaCinco()
        {
            var result = Program.ConverterInteiroPositivo(85);
            Assert.Equal("Oitenta e cinco reais", result);
        }

        [Fact(DisplayName = "099.00 deve ser Noventa e nove reais")]
        public void DeveRetornarNoventaNove()
        {
            var result = Program.ConverterInteiroPositivo(99);
            Assert.Equal("Noventa e nove reais", result);
        }

        [Fact(DisplayName = "123.00 deve ser Cento e vinte e três reais")]
        public void DeveRetornarCentoVinteTres()
        {
            var result = Program.ConverterInteiroPositivo(123);
            Assert.Equal("Cento e vinte e três reais", result);
        }
    }

    public class TestesNumerosEntre1000NegE1000Pos
    {
        [Fact(DisplayName = "#1:  42,00 deve ser Quarenta e dois reais")]
        public void DeveRetornarQuarentaDois()
        {
            var result = Program.ConverterNegativoPositivoFracao(42.00m);
            Assert.Equal("Quarenta e dois reais", result);
        }

        [Fact(DisplayName = "#2: 678,00 deve ser Seiscentos e setenta e oito reais")]
        public void DeveRetornarSeiscentosSetentaOito()
        {
            var result = Program.ConverterNegativoPositivoFracao(678.00m);
            Assert.Equal("Seiscentos e setenta e oito reais", result);
        }

        [Fact(DisplayName = "#3: -23,00 deve ser Vinte e três reais negativo")]
        public void DeveRetornarVinteTresNegativo()
        {
            var result = Program.ConverterNegativoPositivoFracao(-23.00m);
            Assert.Equal("Vinte e três reais negativo", result);
        }

        [Fact(DisplayName = "#4:  13,92 deve ser Treze reais e noventa e dois centavos")]
        public void DeveRetornarTrezeReaisNoventaDoisCentavos()
        {
            var result = Program.ConverterNegativoPositivoFracao(13.92m);
            Assert.Equal("Treze reais e noventa e dois centavos", result);
        }

        [Fact(DisplayName = "#5:1456,00 deve ser Valor inválido")]
        public void DeveRetornarMilQuatrocentosCinquentaSeis()
        {
            var result = Program.ConverterNegativoPositivoFracao(1456.00m);
            Assert.Equal("Valor Inválido", result);
        }

        [Fact(DisplayName = "001.00 deve ser Um real")]
        public void DeveRetornarUm()
        {
            var result = Program.ConverterNegativoPositivoFracao(1);
            Assert.Equal("Um real", result);
        }

        [Fact(DisplayName = "002.00 deve ser Dois reais")]
        public void DeveRetornarDois()
        {
            var result = Program.ConverterNegativoPositivoFracao(2);
            Assert.Equal("Dois reais", result);
        }

        [Fact(DisplayName = "003.00 deve ser Três reais")]
        public void DeveRetornarTres()
        {
            var result = Program.ConverterNegativoPositivoFracao(3);
            Assert.Equal("Três reais", result);
        }

        [Fact(DisplayName = "007.00 deve ser Sete reais")]
        public void DeveRetornarSete()
        {
            var result = Program.ConverterNegativoPositivoFracao(7);
            Assert.Equal("Sete reais", result);
        }

        [Fact(DisplayName = "009.00 deve ser Nove reais")]
        public void DeveRetornarNove()
        {
            var result = Program.ConverterNegativoPositivoFracao(9);
            Assert.Equal("Nove reais", result);
        }

        [Fact(DisplayName = "010.00 deve ser Dez reais")]
        public void DeveRetornarDez()
        {
            var result = Program.ConverterNegativoPositivoFracao(10);
            Assert.Equal("Dez reais", result);
        }

        [Fact(DisplayName = "013.00 deve ser Treze reais")]
        public void DeveRetornarTreze()
        {
            var result = Program.ConverterNegativoPositivoFracao(13);
            Assert.Equal("Treze reais", result);
        }

        [Fact(DisplayName = "017.00 deve ser Dezessete reais")]
        public void DeveRetornarQuinze()
        {
            var result = Program.ConverterNegativoPositivoFracao(17);
            Assert.Equal("Dezessete reais", result);
        }

        [Fact(DisplayName = "021.00 deve ser Vinte e um reais")]
        public void DeveRetornarVinteUm()
        {
            var result = Program.ConverterNegativoPositivoFracao(21);
            Assert.Equal("Vinte e um reais", result);
        }

        [Fact(DisplayName = "029.00 deve ser Vinte e nove reais")]
        public void DeveRetornarVinteNove()
        {
            var result = Program.ConverterNegativoPositivoFracao(29);
            Assert.Equal("Vinte e nove reais", result);
        }

        [Fact(DisplayName = "037.00 deve ser Trinta e sete reais")]
        public void DeveRetornarTrintaSete()
        {
            var result = Program.ConverterNegativoPositivoFracao(37);
            Assert.Equal("Trinta e sete reais", result);
        }

        [Fact(DisplayName = "085.00 deve ser Oitenta e cinco reais")]
        public void DeveRetornarOitentaCinco()
        {
            var result = Program.ConverterNegativoPositivoFracao(85);
            Assert.Equal("Oitenta e cinco reais", result);
        }

        [Fact(DisplayName = "099.00 deve ser Noventa e nove reais")]
        public void DeveRetornarNoventaNove()
        {
            var result = Program.ConverterNegativoPositivoFracao(99);
            Assert.Equal("Noventa e nove reais", result);
        }

        [Fact(DisplayName = "123.00 deve ser Cento e vinte e três reais")]
        public void DeveRetornarCentoVinteTres()
        {
            var result = Program.ConverterNegativoPositivoFracao(123);
            Assert.Equal("Cento e vinte e três reais", result);
        }

        [Fact(DisplayName = "-0.57 deve ser Cinquenta e sete centavos negativo")]
        public void DeveRetornarCinquentaSeteCentavosNegativo()
        {
            var result = Program.ConverterNegativoPositivoFracao(-0.57m);
            Assert.Equal("Cinquenta e sete centavos negativo", result);
        }

        [Fact(DisplayName = "-0.93 deve ser Noventa e três centavos negativo")]
        public void DeveRetornarNoventaTresCentavosNegativo()
        {
            var result = Program.ConverterNegativoPositivoFracao(-0.93m);
            Assert.Equal("Noventa e três centavos negativo", result);
        }
    }
}
