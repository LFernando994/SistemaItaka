using CadastroItaka.DataSource;
using CadastroItaka.Modelos.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CadastroItaka.DAL
{
    public class PessoaDAO
	{
		private Contexto ItakaConnection;
		public PessoaDAO()
		{
			ItakaConnection = new Contexto();
		}

		public List<Pessoa> GetPessoas()
		{
			try
			{
				return ItakaConnection.Pessoas.ToList();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
