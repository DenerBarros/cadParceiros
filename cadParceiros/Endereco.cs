using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadParceiros
{
    internal class Endereco
    {      

        public string CepC { get; set; }
        public string LogradouroC { get; set; }
        public int NumeroC { get; set; }
        public int BairroC { get; set; }
        public string CidadeC { get; set; }
        public string EstadoC { get; set; }
        public string CepE { get; set; }
        public string LogradouroE { get; set; }
        public int NumeroE { get; set; }
        public int BairroE { get; set; }
        public string CidadeE { get; set; }
        public string EstadoE { get; set; }

        public Endereco(string cepC, string logradouroC, int numeroC, int bairroC, string cidadeC, string estadoC, string cepE, string logradouroE, int numeroE, int bairroE, string cidadeE, string estadoE)
        {
            CepC = cepC;
            LogradouroC = logradouroC;
            NumeroC = numeroC;
            BairroC = bairroC;
            CidadeC = cidadeC;
            EstadoC = estadoC;
            CepE = cepE;
            LogradouroE = logradouroE;
            NumeroE = numeroE;
            BairroE = bairroE;
            CidadeE = cidadeE;
            EstadoE = estadoE;
        }

    }
}
