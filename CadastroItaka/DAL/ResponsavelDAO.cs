using CadastroItaka.DataSource;
using CadastroItaka.Modelos.Pessoas;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CadastroItaka.DAL
{
	public class ResponsavelDAO : IDataAccessObject<Responsavel>
	{
		private Contexto ItakaConnection;

		public ResponsavelDAO()
		{
			ItakaConnection = new Contexto();
		}

		public void Insert(Responsavel obj)
		{
			try
			{
                if (!ItakaConnection.Pessoas.Where(x => x.Cpf == obj.Cpf).Any())
                {
                    ItakaConnection.Responsaveis.Add(obj);
                    ItakaConnection.SaveChanges();
                }
			}
			catch (Exception ex)
			{
				throw ex;
			}
            finally
            {
                ItakaConnection.Dispose();
            }
        }

		public void Update(Responsavel obj)
		{
			try
			{
				ItakaConnection.Entry(obj).State = EntityState.Modified;
				ItakaConnection.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
            finally
            {
                ItakaConnection.Dispose();
            }
        }

		public void Delete(Responsavel obj)
		{
			try
			{
				Responsavel responsavel = ItakaConnection.Responsaveis.Find(obj.Id);
				ItakaConnection.Responsaveis.Remove(responsavel);
				ItakaConnection.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
            finally
            {
                ItakaConnection.Dispose();
            }
        }
		public List<Responsavel> GetResponsaveis()
		{
			try
			{
				return ItakaConnection.Responsaveis.ToList();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
    }
}
