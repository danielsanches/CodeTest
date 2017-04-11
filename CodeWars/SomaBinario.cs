using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>
/// Somar dois valores em binario e devolver a soma.
/// </summary>
namespace CodeWars
{
    [TestClass]
    public class SomaBinario
    {
        [TestMethod]
        public void SomarBinario()
        {
            Assert.AreEqual("1001", BinaryNumbers("111", "10"));
            Assert.AreEqual("10010", BinaryNumbers("1101", "101"));
            Assert.AreEqual("100100", BinaryNumbers("1101", "10111"));
            Assert.AreEqual("11", BinaryNumbers("0011", "00"));
            Assert.AreEqual("11", BinaryNumbers("00", "0011"));
            Assert.AreEqual("0", BinaryNumbers("00", "00"));
        }

        private string BinaryNumbers(string a, string b)
        {
            int soma = GetDecimal(a) + GetDecimal(b);
            string binario = GetBit(soma);
            return binario;
        }

        private int GetDecimal(string v)
        {
            int n = 0;
            var multiplicador = 1;
            for (int i = v.Length - 1; i >= 0; i--)
            {
                if (v[i] == '1')
                    n += multiplicador;

                multiplicador *= 2;
            }

            return n;
        }

        private string GetBit(int valor)
        {
            string binario = "";
            do
            {
                if ((valor % 2) == 0)
                    binario = "0" + binario;
                else
                    binario = "1" + binario;

                valor /= 2;

            } while (valor > 0.5);

            return binario;
        }
    }
}
