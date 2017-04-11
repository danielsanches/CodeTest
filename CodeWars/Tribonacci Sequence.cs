using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    [TestClass]
    public class TribonacciSequence
    {
        [TestMethod]
        public void TribonacciSequenceTest()
        {
            Assert.AreEqual(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, Tribonacci(new double[] { 1, 1, 1 }, 10));
            Assert.AreEqual(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }, Tribonacci(new double[] { 0, 0, 1 }, 10));
            Assert.AreEqual(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }, Tribonacci(new double[] { 0, 1, 1 }, 10));
       }

        public double[] Tribonacci(double[] signature, int n)
        {
            if (n == 0)
                return new double[] { 0 };

            var novaLista = signature.ToList();
            var lista = new List<double>();
            for (int i = 0; i < n; i++)
            {
                if (lista.Count == n)
                    break;

                if (novaLista.Any())
                {
                    var temp = novaLista.Take(1).FirstOrDefault();
                    lista.Add(temp);
                    novaLista.Remove(temp);
                }
                else
                {
                    if (lista.Count == 3)
                    {
                        lista.Add(lista.Sum());
                        continue;
                    }

                    lista.Add(lista.Skip(lista.Count - 3).Sum());
                }
            }

            return lista.ToArray();
        }
    }
}
