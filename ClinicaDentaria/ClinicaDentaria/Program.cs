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
            bool resultado;

            Pessoa p1 = new Pessoa("Tone", DescricaoPessoa.FUNCIONARIO, 2, 20);
            Console.WriteLine(p1);

            resultado = UtilizadorClinica.InserePessoa(p1);

            if(resultado == true )
            {
                Console.WriteLine("Inserido!");
            }
            else
            {
                Console.WriteLine("Falhou!");
            }



            //Dados.UtilizadorClinica.ExistePessoa(p1);
            //Dados.UtilizadorClinica.RemoverPessoa(p1);
            //Dados.UtilizadorClinica.GuardaPessoaBinario();
            //Dados.UtilizadorClinica.CarregarFicheiroB();


            Funcionario f1 = new("Alfredo", 22, CargoFuncionario.ASSISTENTE, 33, 987654323, 6, 890);
            Console.WriteLine(f1);


            #endregion


            #region Consultas

            resultado = Dados.Consultas.CarregarConsultaFicheiroB(@"C:\Users\wados\OneDrive\Ambiente de Trabalho\stuff\eduardo\licenciatura\2 ano\Programacao_obj\programacao_objetos_Eduardo_queiros\ClinicaDentaria");
            
            Consulta c1 = new Consulta(10, TipoTratamento.ORTODONTIA, TipoPagamento.CARTAO, DateTime.Now,30);
            Console.WriteLine(c1);
            #endregion



            Console.ReadKey();
        }
    }
}