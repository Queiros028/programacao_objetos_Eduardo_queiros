using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ObjetosNegocio;
using RegrasNegocio;
/* 
 * Main do trabalho prático
 * Author: Eduardo Queirós
 */

namespace ClinicaDentaria
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Utilizadores CLinica
            bool resultado;

            #region Pessoas
            //Console.WriteLine("-----------------------Informacoes da pessoa: --------------------------------");
            //Console.WriteLine("");
            //Pessoa p1 = new Pessoa("Tone", DescricaoPessoa.UTENTE, 2, 20);
            //Pessoa p2 = new Pessoa("Toze", DescricaoPessoa.FUNCIONARIO, 3, 25);
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);


            //#region Funcoes para pessoas

            //Console.WriteLine("");
            //Console.WriteLine("********************Funcoes para Pessoas: ***********************");
            //Console.WriteLine("1- Inserir pessoas:");
            //resultado = RegrasNegocio.GereClinica.InsereUtilizadorValid(p1, 2);

            //if (resultado == true)
            //{
            //    Console.WriteLine("Pessoa inserida!");
            //}
            //else
            //{
            //    Console.WriteLine("Peco desculpa mas nao foi possivel inserir a pessoa!");
            //}

            //resultado = RegrasNegocio.GereClinica.InsereUtilizadorValid(p2, 3);
            //if (resultado == true)
            //{
            //    Console.WriteLine("Pessoa inserida!");
            //}
            //else
            //{
            //    Console.WriteLine("Peco desculpa mas nao foi possivel inserir a pessoa!");
            //}

            //Console.WriteLine("2- Verificar se existe a pessoa: ");
            //resultado = RegrasNegocio.GereClinica.VerificaSePessoaExiste(p1, "Tone");
            //if (resultado == true)
            //{
            //    Console.WriteLine("Essa pessoa existe!");
            //}
            //else
            //{
            //    Console.WriteLine("Peco desculpa mas essa pessoa nao existe!");
            //}

            //resultado = RegrasNegocio.GereClinica.VerificaSePessoaExiste(p1, "Toze");
            //if (resultado == true)
            //{
            //    Console.WriteLine("Essa pessoa existe!");
            //}
            //else
            //{
            //    Console.WriteLine("Peco desculpa mas essa pessoa nao existe!");
            //}

            //Console.WriteLine("3- Remover pessoa: ");
            //resultado = RegrasNegocio.GereClinica.removerP(p2, 3);
            //if (resultado == true)
            //{
            //    Console.WriteLine("Utente removido com sucesso!!");
            //}
            //else
            //{
            //    Console.WriteLine("Erro ao remover o utente");
            //}


            //Console.WriteLine("4- Guardar pessoas em ficheiro: ");
            //resultado = RegrasNegocio.GereClinica.guardaFicheiroP(@"C:\Users\wados\OneDrive\Ambiente de Trabalho\Clinica\pessoas.txt");
            //if (resultado == true)
            //{
            //    Console.WriteLine("Pessoa guardada com suceso!");
            //}
            //else
            //{
            //    Console.WriteLine("Peco desculpa mas nao foi possivel guardar a pessoa!");
            //}

            //Console.WriteLine("5- Carregar ficheiro pessoa: ");
            //resultado = RegrasNegocio.GereClinica.carregarP(@"C:\Users\wados\OneDrive\Ambiente de Trabalho\Clinica\pessoas.txt");
            //if (resultado == true)
            //{
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("Nao foi possivel carregar o ficheiro");
            //}

            //#endregion
            #endregion

            #region utentes
            Console.WriteLine("-----------------------Informacoes do Utente: --------------------------------");
            Console.WriteLine("");
            Utente u1 = new Utente("Joao", "joao@gmail.com", 912345655, 19);
            Utente u2 = new Utente("Abilio", "abilio@gmail.com", 987654321, 35);

            Console.WriteLine(u1.ToString());
            Console.WriteLine(u2.ToString());

            #region funcoes para utentes
            Console.WriteLine("");
            Console.WriteLine("********************Funcoes para Utentes: ***********************");
            Console.WriteLine("1- Inserir pessoas:");

            resultado = RegrasNegocio.GereClinica.InsereUtenteValid(u1, 1);
            if (resultado == true)
            {
                Console.WriteLine("Utente inserido!");
            }
            else
            {
                Console.WriteLine("Peco desculpa mas nao foi possivel inserir o utente!");
            }
            resultado = RegrasNegocio.GereClinica.InsereUtenteValid(u2, 2);
            if (resultado == true)
            {
                Console.WriteLine("Utente inserido!");
            }
            else
            {
                Console.WriteLine("Peco desculpa mas nao foi possivel inserir o utente!");
            }

            Console.WriteLine("2- Verificar se existe o utente: ");
            resultado = RegrasNegocio.GereClinica.VerificaSeUtenteExiste(u1, "Joao");
            if (resultado == true)
            {
                Console.WriteLine("Esse utente existe!");
            }
            else
            {
                Console.WriteLine("Peco desculpa mas esse utente nao existe!");
            }

            resultado = RegrasNegocio.GereClinica.VerificaSeUtenteExiste(u2, "Abilio");
            if (resultado == true)
            {
                Console.WriteLine("Esse utente existe!");
            }
            else
            {
                Console.WriteLine("Peco desculpa mas esse utente nao existe!");
            }

            Console.WriteLine("3- Remover utente");
            resultado = RegrasNegocio.GereClinica.removerU(u2, 2);
            if (resultado == true)
            {
                Console.WriteLine("Utente removido com sucesso!!");
            }
            else
            {
                Console.WriteLine("Erro ao remover o utente");
            }


            Console.WriteLine("4- Guardar utente em ficheiro: ");
            resultado = RegrasNegocio.GereClinica.guardaFicheiroU(@"C:\Users\wados\OneDrive\Ambiente de Trabalho\stuff\eduardo\licenciatura\2 ano\Programacao_obj\programacao_objetos_Eduardo_queiros\ClinicaDentaria\utentes.txt");
            if (resultado == true)
            {
                Console.WriteLine("Utente guardado com suceso!");
            }
            else
            {
                Console.WriteLine("Peco desculpa mas nao foi possivel guardar o determinado utente!");
            }

            Console.WriteLine("5- Carregar ficheiro utentes: ");
            resultado = RegrasNegocio.GereClinica.carregarU(@"C:\Users\wados\OneDrive\Ambiente de Trabalho\stuff\eduardo\licenciatura\2 ano\Programacao_obj\programacao_objetos_Eduardo_queiros\ClinicaDentaria\utentes.txt");
            if (resultado == true)
            {
                Console.WriteLine("Utentes lidos com sucesso!");
            }
            else
            {
                Console.WriteLine("Peco desculpa mas nao foi possivel ler determinados utentes!");
            }

            Console.WriteLine("6- Mostar: ");
            RegrasNegocio.GereClinica.mostrarU();

            #endregion
            #endregion

            #region funcionarios
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-----------------------Informacoes do funcionario: --------------------------------");

            Funcionario f1 = new Funcionario("andre", CargoFuncionario.RECECIONISTA, 987654321, 5, 800, 54);
            Funcionario f2 = new Funcionario("Gustavo", CargoFuncionario.ASSISTENTE, 976543512, 5, 700, 55);
            Console.WriteLine(f1.ToString());
            Console.WriteLine(f2.ToString());

            #region funcoes para funcionarios
            Console.WriteLine("********************Funcoes para Funcionarios: ***********************");

            Console.WriteLine("1- Inserir funcionarios");
            resultado = RegrasNegocio.GereClinica.InsereFuncValid(f1, 3);
            if (resultado == true)
            {
                Console.WriteLine("Funcionario inserido!");
            }
            else
            {
                Console.WriteLine("Peco desculpa mas nao foi possivel inserir esse funcionario!");
            }

            resultado = RegrasNegocio.GereClinica.InsereFuncValid(f2, 4);
            if (resultado == true)
            {
                Console.WriteLine("Funcionario inserido!");
            }
            else
            {
                Console.WriteLine("Peco desculpa mas nao foi possivel inserir esse funcionario!");
            }

            Console.WriteLine("2- Verificar se determinado funcionario existe: ");
            resultado = RegrasNegocio.GereClinica.VerificaSeFuncionarioExiste(f1, "andre");
            if (resultado == true)
            {
                Console.WriteLine("Esse funcionario existe!");
            }
            else
            {
                Console.WriteLine("Peco desculpa mas esse funcionario nao existe!");
            }

            resultado = RegrasNegocio.GereClinica.VerificaSeFuncionarioExiste(f2, "Gustavo");
            if (resultado == true)
            {
                Console.WriteLine("Esse funcionario existe!");
            }
            else
            {
                Console.WriteLine("Peco desculpa mas esse funcionario nao existe!");
            }

            Console.WriteLine("3- Remover funcionario: ");

            resultado = RegrasNegocio.GereClinica.removerF(f2, 4);
            if (resultado == true)
            {
                Console.WriteLine("Funcionario removido com sucesso!!");
            }
            else
            {
                Console.WriteLine("Erro ao remover o funcionario");
            }

            Console.WriteLine("4- Guardar no ficheiro: ");
            resultado = RegrasNegocio.GereClinica.guardaFicheiroF(@"C:\Users\wados\OneDrive\Ambiente de Trabalho\stuff\eduardo\licenciatura\2 ano\Programacao_obj\programacao_objetos_Eduardo_queiros\ClinicaDentaria\funcionarios.txt");
            if (resultado == true)
            {
                Console.WriteLine("Funcionario guardado com suceso!");
            }
            else
            {
                Console.WriteLine("Peco desculpa mas nao foi possivel guardar o determinado funcionario!");
            }

            Console.WriteLine("5- Carregar ficheiro funcionario: ");

            resultado = RegrasNegocio.GereClinica.carregarF(@"C:\Users\wados\OneDrive\Ambiente de Trabalho\stuff\eduardo\licenciatura\2 ano\Programacao_obj\programacao_objetos_Eduardo_queiros\ClinicaDentaria\funcionarios.txt");
            if (resultado == true)
            {
                Console.WriteLine("Funcionarios lidos com sucesso!");
            }
            else
            {
                Console.WriteLine("Peco desculpa mas nao foi possivel ler determinados funcionarios!");
            }
            Console.WriteLine("6- Mostrar: ");
            RegrasNegocio.GereClinica.MostraF();


            #endregion
            #endregion

            #region medicos
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-----------------------Informacoes do Medico: --------------------------------");

            Medico m1 = new Medico("Manuel", 5000, 5, Especialidade.ORTODONTIA, 60);
            Medico m2 = new Medico("Jose", 3500, 6, Especialidade.BRANQUEAMENTO, 55);
            Console.WriteLine(m1.ToString());
            Console.WriteLine(m2.ToString());

            #region funcoes para medicos
            Console.WriteLine("********************Funcoes para Medicos: ***********************");

            Console.WriteLine("1- Inserir Medico: ");
            resultado = RegrasNegocio.GereClinica.InsereMedicoValid(m1, 5);
            if (resultado == true)
            {
                Console.WriteLine("Medico inserido!");
            }
            else
            {
                Console.WriteLine("Peco desculpa mas nao foi possivel inserir esse Medico!");
            }

            resultado = RegrasNegocio.GereClinica.InsereMedicoValid(m2, 6);
            if (resultado == true)
            {
                Console.WriteLine("Medico inserido!");
            }
            else
            {
                Console.WriteLine("Peco desculpa mas nao foi possivel inserir esse Medico!");
            }

            Console.WriteLine("2- Verificar se determinado medico existe:");
            resultado = RegrasNegocio.GereClinica.VerificaSeMedicoExiste(m1, "Manuel");
            if (resultado == true)
            {
                Console.WriteLine("Esse Medico existe!");
            }
            else
            {
                Console.WriteLine("Peco desculpa mas esse Medico nao existe!");
            }
            resultado = RegrasNegocio.GereClinica.VerificaSeMedicoExiste(m2, "Jose");
            if (resultado == true)
            {
                Console.WriteLine("Esse Medico existe!");
            }
            else
            {
                Console.WriteLine("Peco desculpa mas esse Medico nao existe!");
            }

            Console.WriteLine("3- Remover determinado medico: ");
            resultado = RegrasNegocio.GereClinica.removerM(m2, 6);
            if (resultado == true)
            {
                Console.WriteLine("Utente removido com sucesso!!");
            }
            else
            {
                Console.WriteLine("Erro ao remover o utente");
            }

            Console.WriteLine("4- Guardar medico em ficheiro binario");
            resultado = RegrasNegocio.GereClinica.guardaFicheiroM(@"C:\Users\wados\OneDrive\Ambiente de Trabalho\stuff\eduardo\licenciatura\2 ano\Programacao_obj\programacao_objetos_Eduardo_queiros\ClinicaDentaria\medicos.txt");
            if (resultado == true)
            {
                Console.WriteLine("Medico guardado com suceso!");
            }
            else
            {
                Console.WriteLine("Peco desculpa mas nao foi possivel guardar o determinado medico!");
            }

            Console.WriteLine("5- Carregar ficheiro: ");
            resultado = RegrasNegocio.GereClinica.carregarM(@"C:\Users\wados\OneDrive\Ambiente de Trabalho\stuff\eduardo\licenciatura\2 ano\Programacao_obj\programacao_objetos_Eduardo_queiros\ClinicaDentaria\medicos.txt");
            if (resultado == true)
            {
                Console.WriteLine("Medicos lidos com suceso!");
            }
            else
            {
                Console.WriteLine("Peco desculpa mas nao foi possivel ler determinado medico!");
            }
            Console.WriteLine("6- Mostrar: ");
            RegrasNegocio.GereClinica.MostraM();

            #endregion



            #endregion

            #endregion


            #region Consultas
            bool resultadoCons;
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("         Informacoes de Consultas: ");
            Console.WriteLine("");

            Consulta c1 = new Consulta(TipoTratamento.ORTODONTIA, DateTime.Now.AddDays(-2), 30);
            Consulta c2 = new Consulta(TipoTratamento.RESTAURACAO, DateTime.Now, 45);


            Console.WriteLine("1-Inserir Consulta: ");
            resultadoCons = RegrasNegocio.GereClinica.InsereConsultaValid(c1, 1);
            if (resultadoCons == true)
            {
                Console.WriteLine("Consulta inserida!");
            }
            else
            {
                Console.WriteLine("Peco desculpa mas nao foi possivel inserir essa consulta!");
            }
            resultadoCons = RegrasNegocio.GereClinica.InsereConsultaValid(c2, 2);
            if (resultadoCons == true)
            {
                Console.WriteLine("Consulta inserida!");
            }
            else
            {
                Console.WriteLine("Peco desculpa mas nao foi possivel inserir essa consulta!");
            }
            //Console.WriteLine("2-Verificar se determinada consulta existe: ");
            //resultadoCons = RegrasNegocio.GereClinica.VerificaSeConsultaExiste(c1, 1);
            //if (resultadoCons == true)
            //{
            //    Console.WriteLine("A consulta pretendida existe!");
            //}
            //else
            //{
            //    Console.WriteLine("Peco desculpa mas nao existe essa consulta!");
            //}


            Console.WriteLine("3- Remover consulta: ");

            resultadoCons = RegrasNegocio.GereClinica.RemoverConsulta(c1, 2);
            if (resultado == true)
            {
                Console.WriteLine("Consulta removida com sucesso!!");
            }
            else
            {
                Console.WriteLine("Erro ao remover a consulta");
            }


            Console.WriteLine("4- Guardar consulta em ficheiro: ");
            resultadoCons = RegrasNegocio.GereClinica.guardaFicheiroConsulta(@"C:\Users\wados\OneDrive\Ambiente de Trabalho\stuff\eduardo\licenciatura\2 ano\Programacao_obj\programacao_objetos_Eduardo_queiros\ClinicaDentaria\consultas.txt");
            if (resultadoCons == true)
            {
                Console.WriteLine("Medico guardado com suceso!");
            }
            else
            {
                Console.WriteLine("Peco desculpa mas nao foi possivel guardar o determinado medico!");
            }


            Console.WriteLine("5- Carregar dados consulta: ");
            resultadoCons = RegrasNegocio.GereClinica.carregarConsulta(@"C:\Users\wados\OneDrive\Ambiente de Trabalho\stuff\eduardo\licenciatura\2 ano\Programacao_obj\programacao_objetos_Eduardo_queiros\ClinicaDentaria\consultas.txt");
            if (resultadoCons == true)
            {
                Console.WriteLine("Consulta lida com suceso!");
            }
            else
            {
                Console.WriteLine("Peco desculpa mas nao foi possivel ler determinada consulta!");
            }

            Console.WriteLine("6- Mostrar: ");
            //RegrasNegocio.GereClinica.MostraC();
            #endregion



            Console.ReadKey();
        }
    }
}
