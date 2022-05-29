using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ienumerable
{
    public class Exemplo1
    {
        public static void Exemplo()
        {
            var vetor = new int[] { 1, 2, 3 };
            var vetorModificado = vetor
                .Select(elemento =>
                {
                    Console.WriteLine(elemento);
                    return elemento;
                })
                .Select(elemento =>
                {
                    var novoElemento = 2 * elemento;
                    Console.WriteLine(novoElemento);
                    return elemento;
                })
                .ToArray();
        }
    }
}
