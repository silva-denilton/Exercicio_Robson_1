using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Robson_1
{
    internal class Imprimir
    {
        Documento _doc = new Documento();
        public void EnviarImpressao()
        {
            Impressora _imp = new Impressora(_doc);
            _imp.qtdeCopias = 3;
            _imp.Imprimir();
        }
        public void SolicitarTexto()
        {
            _doc.Texto = Console.ReadLine();
        }
    }
}
