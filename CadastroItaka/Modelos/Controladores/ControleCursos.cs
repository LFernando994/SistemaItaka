using CadastroItaka.DataSource;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroItaka.Modelos.Controladores
{
    [Table("ControleCurso")]
	public class ControleCursos
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("Id")]
		public int Id { get => id; set => id = value; }

		[Column("IdCurso")]
		public int IdCurso { get => idCurso; set => idCurso = value; }

        [Column("IdProfessor")]
		public int IdProf { get => idProf; set => idProf = value; }

		private int id;
		private int idCurso;
		private int idProf;

		public ControleCursos(int idcurso, int idprof)
		{
			this.idCurso = idcurso;
			this.idProf = idprof;
		}

		public bool Cadastrar()
		{
			try
			{
				Contexto ItakaConnection = new Contexto();
				ItakaConnection.ControleCurso.Add(this);
				ItakaConnection.SaveChanges();
				ItakaConnection.Dispose();

				return true;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

	}
}
