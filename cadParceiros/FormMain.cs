using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;
using static cadParceiros.Validador;
using Microsoft.EntityFrameworkCore;
using cadParceiros.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace cadParceiros
{
    public partial class FormMain : Form
    {
        MeuDBContext Context = new MeuDBContext();
        private Parceiro parceiro = null;


        public FormMain()
        {
            InitializeComponent();

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

            if (Email.Validar(tbEmailSolicitacao.Text) || Cnpj.Validar(tbEmailSolicitacao.Text))
                tbEmailSolicitacao.BackColor = default(Color);
            else
                tbEmailSolicitacao.BackColor = Color.Red;
        }

        private void tbCPFCNPJ_TextChanged(object sender, EventArgs e)
        {
            if (Cpf.Validar(tbCPFCNPJ.Text) || Cnpj.Validar(tbCPFCNPJ.Text))
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

            if (ValidarCampos() == true)
            {
                var parceiro = CriarParceiro();

                var firstParceiro = Context.Parceiros.FirstOrDefault(p => p.Documento == tbCPFCNPJ.Text);

                

                    if (firstParceiro is not null)
                     {
                       
                            MessageBox.Show("Esse CPF ou CNPJ já existe, dados do Parceiro Atualizados com sucesso!");
                            firstParceiro = AtualizarParceiro(firstParceiro);
                            Context.SaveChanges();
                            carregarComponentesNaTela(parceiro);
                            return;
                     }

                     Context.Add(parceiro);
                     Context.SaveChanges();
                     MessageBox.Show("Usuário Cadastrado com sucesso");
                     carregarComponentesNaTela(parceiro);

     
            }




        }

        private void cbxParceiros_SelectedIndexChanged(object sender, EventArgs e)
        {
            var key = ((KeyValuePair<int, string>)cbxParceiros.SelectedItem).Key;
            var parceiro = Context.Parceiros.Include(p => p.EnderecoCobranca).Include(p => p.EnderecoEntrega).Where(p => p.Id == key).First();
            carregarComponentesNaTela(parceiro);
            this.parceiro = parceiro;

        }

        private void carregarComponentesNaTela(Parceiro parceiro)
        {

            if (parceiro.Status == Status.Cadastrado)
            {
                btnCancelar.Enabled = false;
                btnEmailCadastro.Enabled = true;
                btnCadastro.Enabled = true;
                cbTipoParceiro.Enabled = true;
                cbTipoPessoa.Enabled = true;
                tbEmailSolicitacao.Enabled = true;
                tbNomeParceiro.Enabled = true;
                tbCPFCNPJ.Enabled = true;
                tbEmail.Enabled = true;
                tbTelefone.Enabled = true;
                tbCepC.Enabled = true;
                tbLogradouroC.Enabled = true;
                tbNumeroC.Enabled = true;
                tbBairroC.Enabled = true;
                tbCidadeC.Enabled = true;
                tbEstadoC.Enabled = true;
                tbCepE.Enabled = true;
                tbLogradouroE.Enabled = true;
                tbNumeroE.Enabled = true;
                tbBairroE.Enabled = true;
                tbCidadeE.Enabled = true;
                tbEstadoE.Enabled = true;

            }
            else if (parceiro.Status == Status.Solicitado)
            {
                btnCancelar.Enabled = true;
                btnCadastro.Enabled = true;
                btnCancelar.Enabled = false;
                cbTipoParceiro.Enabled = false;
                cbTipoPessoa.Enabled = false;
                tbEmailSolicitacao.Enabled = false;
                tbNomeParceiro.Enabled = false;
                tbCPFCNPJ.Enabled = false;
                tbEmail.Enabled = false;
                tbTelefone.Enabled = false;
                tbCepC.Enabled = false;
                tbLogradouroC.Enabled = false;
                tbNumeroC.Enabled = false;
                tbBairroC.Enabled = false;
                tbCidadeC.Enabled = false;
                tbEstadoC.Enabled = false;
                tbCepE.Enabled = false;
                tbLogradouroE.Enabled = false;
                tbNumeroE.Enabled = false;
                tbBairroE.Enabled = false;
                tbCidadeE.Enabled = false;
                tbEstadoE.Enabled = false;
            }
            else if (parceiro.Status == Status.Cancelado)
            {
                btnCadastro.Enabled = false;
            }


            cbStatus.SelectedIndex = (int)parceiro.Status;
            cbTipoParceiro.SelectedIndex = (int)parceiro.TipoParceiro;
            cbTipoPessoa.SelectedIndex = (int)parceiro.TipoPessoa;
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

        private void tnbCopiarEndereco_Click(object sender, EventArgs e)
        {

            tbCepE.Text = tbCepC.Text;
            tbLogradouroE.Text = tbLogradouroC.Text;
            tbNumeroE.Text = tbNumeroC.Text;
            tbBairroE.Text = tbBairroC.Text;
            tbCidadeE.Text = tbCidadeC.Text;
            tbEstadoE.Text = tbEstadoC.Text;
        }

        private void cbxParceiros_DropDown(object sender, EventArgs e)
        {
            cbxParceiros.DataSource = Context.Parceiros.Select(t => new KeyValuePair<int, string>(t.Id, t.Nome)).ToList();
            cbxParceiros.DisplayMember = "Value";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (parceiro.Status == Status.Cadastrado)
            {
                parceiro.Status = Status.Cancelado;
                Context.Parceiros.Update(parceiro);
                Context.SaveChanges();
                MessageBox.Show("Usuário Cancelado com sucesso!");
                carregarComponentesNaTela(parceiro);
            }
            else
            if (parceiro.Status == Status.Solicitado)
            {
                MessageBox.Show("Esse parceiro não pode ser cancelado!");
                carregarComponentesNaTela(parceiro);
            }

        }

        private void btnEmailCadastro_Click(object sender, EventArgs e)
        {
            parceiro = CriarParceiro();
            parceiro.Status = Status.Solicitado;
            Context.Parceiros.Add(parceiro);
            Context.SaveChanges();
            carregarComponentesNaTela(parceiro);
            MessageBox.Show("Email enviado com sucesso !");
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private bool ValidarCampos()
        {

            if (cbTipoParceiro.SelectedIndex.ToString() == "")
            {
                MessageBox.Show("Informe se é Cliente ou Fornecedor");
                cbTipoParceiro.Focus();
                return false;
            }
            else
            if (cbTipoPessoa.SelectedIndex.ToString() == "")
            {
                MessageBox.Show("Informe se é Pessoa Física ou Jurídica");
                cbTipoPessoa.Focus();
                return false;
            }
            else
            if (tbEmailSolicitacao.Text == "")
            {
                MessageBox.Show("Informe o email de solicitação");
                tbEmailSolicitacao.Focus();
                return false;
            }
            else if (tbNomeParceiro.Text == "")
            {
                MessageBox.Show("Informe o Nome do Parceiro");
                tbNomeParceiro.Focus();
                return false;
            }
            else
            if (tbCPFCNPJ.Text == "")
            {
                MessageBox.Show("Informe o Cpf ou Cnpj");
                tbCPFCNPJ.Focus();
                return false;
            }
            else
            if (tbCepC.Text == "")
            {
                MessageBox.Show("Informe o CEP do endereço de Cobrança");
                tbCepC.Focus();
                return false;
            }
            else
            if (tbLogradouroC.Text == "")
            {
                MessageBox.Show("Informe o Logradouro de Cobrança");
                tbLogradouroC.Focus();
                return false;
            }
            else
            if (tbNumeroC.Text == "")
            {
                MessageBox.Show("Informe o número do endereço de Cobrança");
                tbNumeroC.Focus();
                return false;
            }
            else
            if (tbBairroC.Text == "")
            {
                MessageBox.Show("Informe o bairro do endereço de Cobrança");
                tbBairroC.Focus();
                return false;
            }
            else
            if (tbEstadoC.Text == "")
            {
                MessageBox.Show("Informe o estado do endereço de Cobrança");
                tbEstadoC.Focus();
                return false;
            }
            else
            if (tbCepE.Text == "")
            {
                MessageBox.Show("Informe o CEP do endereço de Entrega");
                tbCepE.Focus();
                return false;
            }
            else
            if (tbLogradouroE.Text == "")
            {
                MessageBox.Show("Informe o Logradouro de Entrega");
                tbLogradouroE.Focus();
                return false;
            }
            else
            if (tbNumeroE.Text == "")
            {
                MessageBox.Show("Informe o número do endereço de Entrega");
                tbNumeroE.Focus();
                return false;
            }
            else
            if (tbBairroE.Text == "")
            {
                MessageBox.Show("Informe o bairro do endereço de Entrega");
                tbBairroE.Focus();
                return false;
            }
            else
            if (tbEstadoE.Text == "")
            {
                MessageBox.Show("Informe o estado do endereço de Entrega");
                tbEstadoE.Focus();
                return false;
            }
            return true;
        }

        private Parceiro CriarParceiro()
        {
            return new Parceiro
            {
                Email = tbEmail.Text,
                Documento = tbCPFCNPJ.Text,
                Nome = tbNomeParceiro.Text,
                EmailSolicitacao = tbEmailSolicitacao.Text,
                Telefone = tbTelefone.Text,
                TipoParceiro = (TipoParceiro)Enum.Parse(typeof(TipoParceiro), cbTipoParceiro.SelectedItem.ToString()),
                TipoPessoa = (TipoPessoa)Enum.Parse(typeof(TipoPessoa), cbTipoPessoa.SelectedItem.ToString()),
                Status = Status.Cadastrado,
                EnderecoEntrega = new EnderecoEntrega
                {
                    Cep = tbCepE.Text,
                    Bairro = tbBairroE.Text,
                    Cidade = tbCidadeE.Text,
                    Estado = tbEstadoE.Text,
                    Logradouro = tbLogradouroE.Text,
                    Numero = int.Parse(tbNumeroE.Text),

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
        }

        private Parceiro AtualizarParceiro(Parceiro parceiro)
        {
            parceiro.Email = tbEmail.Text;
            parceiro.Documento = tbCPFCNPJ.Text;
            parceiro.Nome = tbNomeParceiro.Text;
            parceiro.EmailSolicitacao = tbEmailSolicitacao.Text;
            parceiro.Telefone = tbTelefone.Text;
            parceiro.TipoParceiro = (TipoParceiro)Enum.Parse(typeof(TipoParceiro), cbTipoParceiro.SelectedItem.ToString());
            parceiro.TipoPessoa = (TipoPessoa)Enum.Parse(typeof(TipoPessoa), cbTipoPessoa.SelectedItem.ToString());
            parceiro.Status = Status.Cadastrado;
            parceiro.EnderecoEntrega.Bairro = tbBairroE.Text;
            parceiro.EnderecoEntrega.Cidade = tbCidadeE.Text;
            parceiro.EnderecoEntrega.Estado = tbEstadoE.Text;
            parceiro.EnderecoEntrega.Cep = tbCepE.Text;
            parceiro.EnderecoEntrega.Logradouro = tbLogradouroE.Text;
            parceiro.EnderecoEntrega.Numero = int.Parse(tbNumeroE.Text);
            parceiro.EnderecoCobranca.Cep = tbCepC.Text;
            parceiro.EnderecoCobranca.Bairro = tbBairroC.Text;
            parceiro.EnderecoCobranca.Cidade = tbCidadeC.Text;
            parceiro.EnderecoCobranca.Estado = tbEstadoC.Text;
            parceiro.EnderecoCobranca.Logradouro = tbLogradouroC.Text;
            parceiro.EnderecoCobranca.Numero = int.Parse(tbNumeroC.Text);

            return parceiro;

        }
    }
}
