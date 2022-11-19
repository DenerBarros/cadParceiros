using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadParceiros;

public class Endereco 
{
    public int Id { get; set; }
    public string Cep { get; set; }
    public string Logradouro { get; set; }
    public int Numero { get; set; }
    public int Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public Parceiro Parceiro { get; set; }


}
