using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetosNegocio;
using RegrasNegocio;
using Dados;

namespace Clinic
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Utilizadores CLinica
            Pessoa p1 = new Pessoa("Tone", DescricaoPessoa.FUNCIONARIO,2, 20);
            UtilizadorClinica.InserePessoa(p1, dia);


            #endregion


            #region Consultas

            #endregion



            Console.ReadKey();
        }
    }
}