using CadastroItaka.DataSource;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppAluno
{
    public partial class CadLista : Form
    {
        private Contexto db;
        public CadLista()
        {
            InitializeComponent();
            db = new Contexto();
          
        }

        private void CadLista_Load(object sender, EventArgs e)
        {
            //Comando p/ trazer dados de alunos cadastrados no sistema
            var query = from pessoa in db.Pessoas
                        join aluno in db.Alunos on pessoa.Id equals aluno.Id
                        join responsavel in db.Responsaveis on aluno.IdResponsavel equals responsavel.Id
                        where aluno.Status == true
                        select new
                        {
                            Id = pessoa.Id,
                            Nome = pessoa.Nome,
                            Rg = pessoa.Rg,
                            Idade = pessoa.Idade,
                            NomeResponsavel = responsavel.Nome,
                            RgResponsavel = responsavel.Rg,
                            TelResponsavel = responsavel.TelCelular,
                            DataCadastroAluno = pessoa.DataCadastro
                        };

            GvAlunos.DataSource = query.ToList();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         string   x = GvAlunos.CurrentRow.Cells[0].Value.ToString();

            AppFrequencia f = new AppFrequencia();
            f.x = x;
            f.ShowDialog();
        }

    }
}
