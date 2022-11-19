using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;
using static cadParceiros.Validador;
using Microsoft.EntityFrameworkCore;
using cadParceiros.Data;

namespace cadParceiros
{
    public partial class FormMain : Form
    {
        MeuDBContext Context = new MeuDBContext();


        public FormMain()
        {
            InitializeComponent();
            cbxParceiros.DataSource = Context.Parceiros.Select(t => new KeyValuePair<int, string>(t.Id, t.Nome)).ToList();
            cbxParceiros.DisplayMember = "Value";          
        }

       

        private void Informar(string mensagem)
        {
            MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool Confirmar(string pergunta)
        {
            return MessageBox.Show(pergunta, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbEmailSolicitacao_TextChanged(object sender, EventArgs e)
        {
            if (Email.Validar(tbEmailSolicitacao.Text))
                tbEmailSolicitacao.BackColor = default(Color);
            else
                tbEmailSolicitacao.BackColor = Color.Red;
        }

        private void tbCPFCNPJ_TextChanged(object sender, EventArgs e)
        {
            if(Cpf.Validar(tbCPFCNPJ.Text))
                tbCPFCNPJ.BackColor = default(Color);
            else
                tbCPFCNPJ.BackColor = Color.Red;
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (Email.Validar(tbEmail.Text))
                tbEmail.BackColor = default(Color);
            else
                tbEmail.BackColor = Color.Red;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            var parceiro = new Parceiro
            {
                Email = tbEmail.Text,
                Documento = tbCPFCNPJ.Text,
                Nome = tbNomeParceiro.Text,
                EmailSolicitacao = tbEmailSolicitacao.Text,
                Telefone = tbTelefone.Text,                
                EnderecoEntrega = new EnderecoEntrega { 
                    Cep= tbCepE.Text,
                    Bairro= tbBairroE.Text,
                    Cidade= tbCidadeE.Text,
                    Estado= tbEstadoE.Text,
                    Logradouro= tbLogradouroE.Text,
                    Numero= int.Parse(tbNumeroE.Text),                     

                },
                EnderecoCobranca = new EnderecoCobranca
                {
                    Cep = tbCepC.Text,
                    Bairro = tbBairroC.Text,
                    Cidade = tbCidadeC.Text,
                    Estado = tbEstadoC.Text,
                    Logradouro = tbLogradouroC.Text,
                    Numero = int.Parse(tbNumeroC.Text),

                }

            };
            Context.Add(parceiro);
            Context.SaveChanges();
            
        }

        private void cbxParceiros_SelectedIndexChanged(object sender, EventArgs e)
        {
            var key = ((KeyValuePair<int, string>)cbxParceiros.SelectedItem).Key;
            var parceiro = Context.Parceiros.Include(p => p.EnderecoCobranca).Include(p => p.EnderecoEntrega).Where(p => p.Id == key).First();
         
        }

        private void carregarComponentesNaTela(Parceiro parceiro) 
        {
            tbEmailSolicitacao.Text = parceiro.EmailSolicitacao;
            tbNomeParceiro.Text = parceiro.Nome;
            tbCPFCNPJ.Text = parceiro.Documento;
            tbEmail.Text = parceiro.Email;
            tbTelefone.Text = parceiro.Telefone;
            tbCepC.Text = parceiro.EnderecoCobranca.Cep;
            tbLogradouroC.Text = parceiro.EnderecoCobranca.Logradouro;
            tbNumeroC.Text = parceiro.EnderecoCobranca.Numero.ToString();
            tbBairroC.Text = parceiro.EnderecoCobranca.Bairro;
            tbCidadeC.Text = parceiro.EnderecoCobranca.Cidade;
            tbEstadoC.Text = parceiro.EnderecoCobranca.Estado;
            tbCepE.Text = parceiro.EnderecoEntrega.Cep;
            tbLogradouroE.Text = parceiro.EnderecoEntrega.Logradouro;
            tbNumeroE.Text = parceiro.EnderecoEntrega.Numero.ToString();
            tbBairroE.Text = parceiro.EnderecoEntrega.Bairro;
            tbCidadeE.Text = parceiro.EnderecoEntrega.Cidade;
            tbEstadoE.Text = parceiro.EnderecoEntrega.Estado;

        }
    }
}