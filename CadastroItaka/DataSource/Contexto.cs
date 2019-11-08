using System.Data.Entity;
using System.Configuration;
using CadastroItaka.Modelos.Pessoas;
using CadastroItaka.Modelos.Matriculados;
using CadastroItaka.Modelos;
using CadastroItaka.Modelos.Controladores;

namespace CadastroItaka.DataSource
{
    public class Contexto : DbContext
    {
        public Contexto() : base(ConfigurationManager.ConnectionStrings["DbItaka"].ConnectionString) { } 

		#region Pessoa

		public DbSet<Pessoa> Pessoas { get; set; }
		public DbSet<Aluno> Alunos { get; set; }
		public DbSet<Responsavel> Responsaveis { get; set; }
		public DbSet<Professor> Professores { get; set; }

		#endregion

		public DbSet<Turma> Turmas { get; set; }
		//public DbSet<Aula> Aulas { get; set; }
		public DbSet<Curso> Cursos { get; set; }
		public DbSet<Endereco> Enderecos { get; set; }
		public DbSet<ControleCursos> ControleCurso { get; set; }
        public DbSet<Matriculado> Matriculados { get; set; }

    }
}
