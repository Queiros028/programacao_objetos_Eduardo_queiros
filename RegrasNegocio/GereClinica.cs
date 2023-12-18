/*
 * Regras da clínica
 *Autor: Eduardo Queirós, nº 23005
 *
 */
using System;
using ObjetosNegocio;
using Dados;
using Validacoes;
using static System.Net.Mime.MediaTypeNames;

namespace RegrasNegocio
{
    public class GereClinica
    {
        public GereClinica() 
        {
            
        }

        /// <summary>
        /// Regra de negócio ao inserir pessoa
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
   /*
        public static bool InserePessoa(Pessoa p)
        {
            if (p.tipo != DescricaoPessoa.UTENTE)     // Regra de negocio
            {
                return UtilizadorClinica.InserePessoa(p);
            }
            return false;
        }
   */
        /// <summary>
        /// Idade válida para ser utente da clínica
        /// </summary>
        /// <param name="idade"></param>
        /// <returns></returns>
        public static bool IdadeValidaUtente(int idade)
        {
            return (idade > 5 && idade < 100);
        }

        /// <summary>
        /// Idade valida para poder trabalhar na clínica
        /// </summary>
        /// <param name="idade"></param>
        /// <returns></returns>
        public static bool IdadeValidaTrab(int idade)
        {
            return (idade > 18 && idade < 65);

        }
    }
}
