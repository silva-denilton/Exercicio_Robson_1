using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Robson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Imprimir imprimir = new Imprimir();

            imprimir.SolicitarTexto();
            imprimir.EnviarImpressao();
        }
    }
}
