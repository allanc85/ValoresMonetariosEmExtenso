using System;
using System.Collections.Generic;

namespace ConverterValoresMonetariosEmExtenso
{
    public static class Program
    {
        private struct Base
        {
            public decimal numeroDecimal;
            public string numeroExtenso;
            public string numeroExtensoComResto;
            public string RetornarValorExtenso(decimal resto)
            {
                return ( resto <= -1 || resto >= 1 ) && (!String.IsNullOrEmpty(numeroExtensoComResto)) ? numeroExtensoComResto : numeroExtenso;
            }
        }

        private static List<Base> valoresBase = new List<Base>() {
            new Base { numeroDecimal = 900, numeroExtenso = "novecentos" },
            new Base { numeroDecimal = 800, numeroExtenso = "oitocentos" },
            new Base { numeroDecimal = 700, numeroExtenso = "setecentos" },
            new Base { numeroDecimal = 600, numeroExtenso = "seiscentos" },
            new Base { numeroDecimal = 500, numeroExtenso = "quinhentos" },
            new Base { numeroDecimal = 400, numeroExtenso = "quatrocentos" },
            new Base { numeroDecimal = 300, numeroExtenso = "trezentos" },
            new Base { numeroDecimal = 200, numeroExtenso = "duzentos" },
            new Base { numeroDecimal = 100, numeroExtenso = "cem", numeroExtensoComResto = "cento" },
            new Base { numeroDecimal =  90, numeroExtenso = "noventa" },
            new Base { numeroDecimal =  80, numeroExtenso = "oitenta" },
            new Base { numeroDecimal =  70, numeroExtenso = "setenta" },
            new Base { numeroDecimal =  60, numeroExtenso = "sessenta" },
            new Base { numeroDecimal =  50, numeroExtenso = "cinquenta" },
            new Base { numeroDecimal =  40, numeroExtenso = "quarenta" },
            new Base { numeroDecimal =  30, numeroExtenso = "trinta" },
            new Base { numeroDecimal =  20, numeroExtenso = "vinte" },
            new Base { numeroDecimal =  19, numeroExtenso = "dezenove" },
            new Base { numeroDecimal =  18, numeroExtenso = "dezoito" },
            new Base { numeroDecimal =  17, numeroExtenso = "dezessete" },
            new Base { numeroDecimal =  16, numeroExtenso = "dezesseis" },
            new Base { numeroDecimal =  15, numeroExtenso = "quinze" },
            new Base { numeroDecimal =  14, numeroExtenso = "quatorze" },
            new Base { numeroDecimal =  13, numeroExtenso = "treze" },
            new Base { numeroDecimal =  12, numeroExtenso = "doze" },
            new Base { numeroDecimal =  11, numeroExtenso = "onze" },
            new Base { numeroDecimal =  10, numeroExtenso = "dez" },
            new Base { numeroDecimal =   9, numeroExtenso = "nove" },
            new Base { numeroDecimal =   8, numeroExtenso = "oito" },
            new Base { numeroDecimal =   7, numeroExtenso = "sete" },
            new Base { numeroDecimal =   6, numeroExtenso = "seis" },
            new Base { numeroDecimal =   5, numeroExtenso = "cinco" },
            new Base { numeroDecimal =   4, numeroExtenso = "quatro" },
            new Base { numeroDecimal =   3, numeroExtenso = "três" },
            new Base { numeroDecimal =   2, numeroExtenso = "dois" },
            new Base { numeroDecimal =   1, numeroExtenso = "um" }
        };

        private static List<Base> ValoresBase { get => valoresBase; set => valoresBase = value; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var teste = Converter(3);
        }

        public static string FirstCharToUpper(this string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("Insira uma palavra diferente de nula ou vazia");

            return input.Length > 1 ? char.ToUpper(input[0]) + input.Substring(1) : input.ToUpper();
        }

        public static string InserirMoeda(this string input, decimal decNum)
        {
            return decNum == 1 ? input + " real" : input + " reais";
        }

        public static string ConverterDecimal(decimal decNum)
        {
            foreach (var baseDec in valoresBase)
            {
                if (decNum / baseDec.numeroDecimal >= 1)
                {
                    decimal dif = decNum - baseDec.numeroDecimal;
                    return dif == 0 ? baseDec.RetornarValorExtenso(dif) : baseDec.RetornarValorExtenso(dif) + " e " + ConverterDecimal(dif);
                }
            }
            return "";
        }

        public static string Converter(decimal decNum)
        {
            // Não aceita valores decimais (centavos), negativo e superiores a 999,00
            if (decNum % 1 != 0 || decNum < 0 || decNum >= 1000)
            {
                return "Valor Inválido";
            }

            return ConverterDecimal(decNum).FirstCharToUpper().InserirMoeda(decNum);
        }
    }
}
