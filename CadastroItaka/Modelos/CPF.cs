using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroItaka.Modelos
{
    public abstract class CPF
    {
        /// <summary>
        /// Método que valida o CPF informado pelo usuário.
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public static bool ValidarCPF(string cpf)
        {
            int[] mult1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mult2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCPF, digito;
            int resto, soma;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
            {
                return false;
            }
            tempCPF = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCPF[i].ToString()) * mult1[i];
            }
            resto = soma % 11;
            if(resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            digito = resto.ToString();
            tempCPF += digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(tempCPF[i].ToString()) * mult2[i];
            }
            resto = soma % 11;
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            digito += resto.ToString();
            return cpf.EndsWith(digito);
        }
    }
}
