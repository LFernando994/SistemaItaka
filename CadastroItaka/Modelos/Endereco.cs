using CadastroItaka.DAL;
using CadastroItaka.Modelos.Pessoas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroItaka.Modelos
{
    [Table("Enderecos")]
    public class Endereco
    {	
		[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get => id; set => id = value; }

        [ForeignKey("Pessoa")]
        [Column("IdPessoaEndereco")]
        public int IdPessoa { get => idPessoa; set => idPessoa = value; }

        [Column("Cep")]
        public string Cep { get => cep; set => cep = value; }

        [Column("Numero")]
        public string Numero { get => numero; set => numero = value; }

        [Column("Rua")]
        public string Rua { get => rua; set => rua = value; }

        [Column("Complemento")]
        public string Complemento { get => complemento; set => complemento = value; }

        [Column("Bairro")]
        public string Bairro { get => bairro; set => bairro = value; }

        [Column("Cidade")]
        public string Cidade { get => cidade; set => cidade = value; }

        [Column("Estado")]
        public string Estado { get => estado; set => estado = value; }
		
		[Column("DataCadastro")]
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }

        public Pessoa Pessoa { get => pessoa; set => pessoa = value; }

        private Pessoa pessoa;
        private int id;
        private int idPessoa;
        private string rua;
        private string cep;
        private string numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string estado;
        private DateTime dataCadastro;

        private EnderecoDAO enderecoDAO;
		public Endereco() { }
        public Endereco(int idPessoa, string rua, string cep, string numero, string complemento, string bairro, string cidade, string estado)
        {
            this.enderecoDAO = new EnderecoDAO();
            this.idPessoa = idPessoa;
            this.rua = rua;
            this.cep = cep;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
        }

        public bool Cadastrar()
        {
            try
            {
                this.enderecoDAO.Insert(this);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Editar()
        {
            try
            {
                this.enderecoDAO.Insert(this);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Excluir()
        {
            try
            {
                this.enderecoDAO.Delete(this);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		public List<Endereco> GetEnderecos()
		{
			try
			{
				return this.enderecoDAO.GetEnderecos();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int GetId(int idPessoa)
        {
            return this.enderecoDAO.GetId(idPessoa);
        }
    }
}
