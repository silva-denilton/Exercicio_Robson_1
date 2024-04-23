using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercicio_Robson_1
{
    internal class Impressora
    {
        Documento _docImprimir;
        public int qtdeCopias;
        public Impressora(Documento _documento)
        {
            _docImprimir = _documento;

        }
        public void Imprimir()
        {
            for (int i = 1; i <= qtdeCopias; i++)
            {
                Console.WriteLine(_docImprimir.Texto);
            }
        }
    }
}
