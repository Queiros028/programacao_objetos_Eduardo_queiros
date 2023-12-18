/*
 *Main program Clínica Dentária
 *Autor: Eduardo Queirós, nº 23005
 *
 */
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
            Console.WriteLine(p1);

            #endregion


            #region Consultas

            #endregion



            Console.ReadKey();
        }
    }
}