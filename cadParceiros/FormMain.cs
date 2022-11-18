using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;
using static cadParceiros.Validador;

namespace cadParceiros
{
    public partial class FormMain : Form
    {
    
        public FormMain()
        {
            InitializeComponent();
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
    }
}