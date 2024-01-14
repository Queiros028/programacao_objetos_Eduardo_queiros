using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Dados;
using ObjetosNegocio;
/*
 * Regras da clínica 
 */

namespace RegrasNegocio
{
    public class GereClinica
    {
        public GereClinica()
        {

        }

        #region regras pessoa

        ///// <summary>
        ///// Regra de negócio ao inserir pessoa
        ///// </summary>
        ///// <param name="p"></param>
        ///// <returns></returns>

        //public static bool InsereUtilizadorValid(Pessoa p, int id)
        //{

        //    if (p.Nome != null)
        //    {
        //        return UtilizadorClinica.InserePessoa(p, id);
        //    }
        //    return false;
        //}

        ///// <summary>
        ///// Verficar se pessoa existe, so existe se o nome nao for nulo
        ///// </summary>
        ///// <param name="p"></param>
        ///// <param name="nome"></param>
        ///// <returns></returns>
        //public static bool VerificaSePessoaExiste(Pessoa p, string nome)
        //{
        //    if (p.Nome != null)
        //    {
        //        return UtilizadorClinica.ExistePessoa(nome);
        //    }
        //    return false;
        //}

        ///// <summary>
        ///// Guardar pessoa no ficheiro
        ///// </summary>
        ///// <param name="nomeFicheiro"></param>
        ///// <returns></returns>
        //public static bool guardaFicheiroP(string nomeFicheiro)
        //{
        //    return UtilizadorClinica.GuardaPessoaBinario(nomeFicheiro);
        //}

        ///// <summary>
        ///// Carregar ficheiro binario de pessoa
        ///// </summary>
        ///// <param name="nomeFicheiro"></param>
        ///// <returns></returns>
        //public static bool carregarP(string nomeFicheiro)
        //{
        //    return UtilizadorClinica.CarregarPessoaFicheiroB(nomeFicheiro);
        //}

        ///// <summary>
        ///// Regras para remover pessoa
        ///// </summary>
        ///// <param name="p"></param>
        ///// <param name="id"></param>
        ///// <returns></returns>
        ///// <exception cref="Exception"></exception>
        //public static bool removerP(Pessoa p, int id)
        //{
        //    return UtilizadorClinica.RemoverPessoa(p, id);
        //    //if (p.Nome != null)
        //    //{                   
        //    //    return UtilizadorClinica.RemoverPessoa(p, id);
        //    //}
        //    //return false;
        //}

        #endregion

        #region regras utentes

        public static bool InsereUtenteValid(Utente u, int id)
        {
            if (u.tipo == DescricaoPessoa.UTENTE)     // Regra de negocio
            {
                if ((u.Idade >= 5 && u.Idade <= 100) && (u.Nome != null) && (u.Mail != null))
                {
                    return UtilizadorClinica.InsereUtente(u, id);
                }
                else
                {
                    Console.WriteLine("Nao e possivel inserir o utente");
                }

            }
            return false;
        }

        /// <summary>
        /// Verificar se existe utente, só existe se o nome nao for nulo
        /// </summary>
        /// <param name="u"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static bool VerificaSeUtenteExiste(Utente u, string nome)
        {
            if (u.Nome != null)
            {
                return UtilizadorClinica.ExisteUtente(nome);
            }
            return false;
        }

        /// <summary>
        /// Regra para guardar as informacoes do utente num ficheiro
        /// </summary>
        /// <param name="u"></param>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool guardaFicheiroU(string nomeFicheiro)
        {
            return UtilizadorClinica.GuardaUtenteBinario(nomeFicheiro);
        }

        /// <summary>
        /// Carregar/ler ficheiro utente
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool carregarU(string nomeFicheiro)
        {
            return UtilizadorClinica.CarregarUtenteFicheiroB(nomeFicheiro);
        }

        /// <summary>
        /// Regra para remover utente
        /// </summary>
        /// <param name="u"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool removerU(Utente u, int id)
        {
            if (u.Nome != null)
            {
                if (id > 0)
                {
                    return UtilizadorClinica.RemoverUtente(u, id);
                }
                throw new Exception("O id tem de ser maior que 0");
            }
            throw new Exception("O nome nao existe");
        }
        /// <summary>
        /// Mostrar o dictionary de utentes
        /// </summary>
        public static void mostrarU()
        {
            UtilizadorClinica.VerDictionaryU();
        }


        #endregion

        #region regras funcionarios
        public static bool InsereFuncValid(Funcionario f, int id)
        {

            if ((f.Idade >= 18 && f.Idade < 70) && (f.Salario >= 700) && (f.Horario >= 4 && f.Horario <= 7))
            {
                return UtilizadorClinica.InsereFuncionario(f, id);
            }
            else
            {
                Console.WriteLine("Nao e possivel inserir o funcionario");
            }
            return false;
        }

        /// <summary>
        /// Verificar se o funcionario existe, so existe se o nome nao for nulo
        /// </summary>
        /// <param name="u"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static bool VerificaSeFuncionarioExiste(Funcionario f, string nome)
        {
            if (f.Nome != null)
            {
                return UtilizadorClinica.ExisteFuncionario(nome);
            }
            return false;
        }

        /// <summary>
        /// Guardar funcionario num ficheiro binario
        /// </summary>
        /// <param name="f"></param>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool guardaFicheiroF(string nomeFicheiro)
        {
            return UtilizadorClinica.GuardaFuncionarioBinario(nomeFicheiro);
        }

        /// <summary>
        /// Carregar/ler ficheiro funcionario
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool carregarF(string nomeFicheiro)
        {
            return UtilizadorClinica.CarregarFuncionarioFicheiroB(nomeFicheiro);
        }

        /// <summary>
        /// Regra para remover funcionario
        /// </summary>
        /// <param name="f"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool removerF(Funcionario f, int id)
        {
            if (f.Nome != null)
            {
                return UtilizadorClinica.RemoverFuncionario(f, id);
            }
            throw new Exception("O nome nao existe");
        }

        /// <summary>
        /// Mostrar dictionary de funcionarios
        /// </summary>
        public static void MostraF()
        {
            UtilizadorClinica.VerDictionaryF();
        }

        #endregion

        #region regras medicos

        public static bool InsereMedicoValid(Medico m, int id)
        {


            if ((m.Idade >= 23 && m.Idade < 65) && ((m.TipoEspecialidade == Especialidade.DESVITALIZACAO) || (m.TipoEspecialidade == Especialidade.ORTODONTIA)
            || (m.TipoEspecialidade == Especialidade.BRANQUEAMENTO) || (m.TipoEspecialidade == Especialidade.RESTAURACAO)) && (m.HorarioTrabalho >= 4 && m.HorarioTrabalho <= 7))
            {
                return UtilizadorClinica.InsereMedico(m, id);
            }
            else
            {
                Console.WriteLine("Nao e possivel inserir o medico");
            }

            return false;
        }

        /// <summary>
        /// Verifica se o funcionario existe, so existe caso o nome nao for nulo
        /// </summary>
        /// <param name="m"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static bool VerificaSeMedicoExiste(Medico m, string nome)
        {
            if (m.Nome != null)
            {
                return UtilizadorClinica.ExisteMedico(nome);
            }
            return false;
        }

        /// <summary>
        /// Guardar medico num ficheiro binario
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool guardaFicheiroM(string nomeFicheiro)
        {
            return UtilizadorClinica.GuardaMedicoBinario(nomeFicheiro);
        }

        /// <summary>
        /// Carregar/ler ficheiro de medico
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool carregarM(string nomeFicheiro)
        {
            return UtilizadorClinica.CarregarMedicoFicheiroB(nomeFicheiro);
        }

        /// <summary>
        /// Regra para remover medico
        /// </summary>
        /// <param name="m"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool removerM(Medico m, int id)
        {
            if (m.Nome != null)
            {
                if (id > 0)
                {
                    return UtilizadorClinica.RemoverMedico(m, id);
                }
                throw new Exception("O id tem de ser maior que 0");
            }
            throw new Exception("O nome nao existe");
        }

        /// <summary>
        /// Mostrar dictionary de medicos
        /// </summary>
        public static void MostraM()
        {
            UtilizadorClinica.VerDictionaryM();
        }


        #endregion


        #region regras consultas

        /// <summary>
        /// Regra de negocio ao inserir consulta
        /// </summary>
        /// <param name="c"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool InsereConsultaValid(Consulta c, int id)
        {

            //if (c.idConsulta > 0)
            //{
            return Consultas.RegistaConsulta(c, id);
            //}
            //return false;
        }

        /// <summary>
        /// Verificar se consulta existe, caso o id da consulta for maior que 0
        /// </summary>
        /// <param name="c"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool VerificaSeConsultaExiste(Consulta c, int id)
        {
            //if (c.idConsulta > 0)
            //{
            return Consultas.ExisteConsulta(id, c);
            //}
            //return false;
        }

        /// <summary>
        /// Guardar dados da consulta num ficheiro binario
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool guardaFicheiroConsulta(string nomeFicheiro)
        {
            return Consultas.GuardaConsultaBinario(nomeFicheiro);
        }

        /// <summary>
        /// Carregar/ler ficheiro binario de consultas
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool carregarConsulta(string nomeFicheiro)
        {
            return Consultas.CarregarConsultaFicheiroB(nomeFicheiro);
        }

        /// <summary>
        /// Regra para remover consulta
        /// </summary>
        /// <param name="c"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool RemoverConsulta(Consulta c, int id)
        {
            {
                if (id > 0)
                {
                    return Consultas.RemoverConsulta(c, id);
                }
                throw new Exception("O id tem de ser maior que 0");
            }

        }

        /// <summary>
        /// Mostrar dictionary de consultas
        /// </summary>
        public static void MostraC()
        {
            Consultas.VerDictionaryC();
        }


        #endregion

    }
}