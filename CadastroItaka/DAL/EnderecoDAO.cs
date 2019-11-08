using CadastroItaka.DataSource;
using CadastroItaka.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CadastroItaka.DAL
{
    public class EnderecoDAO : IDataAccessObject<Endereco>
    {
        private Contexto ItakaConnection;

        public EnderecoDAO()
        {
            ItakaConnection = new Contexto();
        }

        public void Insert(Endereco obj)
        {
            try
            {
                ItakaConnection.Enderecos.Add(obj);
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

        public void Update(Endereco obj)
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

        public void Delete(Endereco obj)
        {
            try
            {
                ItakaConnection.Entry(obj).State = EntityState.Deleted;
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

		public List<Endereco> GetEnderecos()
        {
			try
			{
				return ItakaConnection.Enderecos.ToList();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int GetId(int idPessoa)
        {
            try
            {
                return ItakaConnection.Enderecos.Where(x => x.IdPessoa == idPessoa).Select(e => e.Id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
