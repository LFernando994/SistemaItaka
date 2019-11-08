using AppMenu;
using System;
using System.Windows.Forms;

namespace CadastroItaka
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
           
            string loginPadrao = "admin";
            string senhaPadrao = "admin";
           
            string login = txtLogin.Text;
            string senha = txtSenha.Text;
           
            
            if (login == loginPadrao && senha == senhaPadrao )
            {
                timer1.Start();
            }
            else
            {
                MessageBox.Show("VERIFIQUE O LOGIN E A SENHA NOVAMENTE ", "Campo Inválido ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Increment(5);
            if (progressBar1.Value == 100)
            {
                MenuInicial c = new MenuInicial();
                timer1.Stop();
                c.ShowDialog();

                progressBar1.Increment(-100);
            }
        }

		private void TelaLogin_Load(object sender, EventArgs e)
		{

		}
	}
}
