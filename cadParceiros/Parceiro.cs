using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadParceiros
{
    public class Parceiro
    {      

        public string Nome { get; set; }
        public string EmailSolicitacao { get; set; }
        public long Cpfcnpj { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public Parceiro(string nome, string emailSolicitacao, long cpfcnpj, string email, string telefone)
        {
            this.Nome = nome;
            this.EmailSolicitacao = emailSolicitacao;
            this.Cpfcnpj = cpfcnpj;
            this.Email = email;
            this.Telefone = telefone;
        }


    }
}
