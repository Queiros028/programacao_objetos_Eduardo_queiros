using System;
using ObjetosNegocio;

namespace Dados
{
    public class Consultas
    {
        //dictionary de Consulta que foi criada em ObjetosNegocio
        static Dictionary<int, List<Consulta>> consulta = new Dictionary<int, List<Consulta>>();


        private static void inicializConsulta()
        {
            consulta = new Dictionary<int, List<Consulta>>();
        }
        
        static Consultas()
        {
            inicializConsulta();    
        }
        /// <summary>
        /// inserir uma consulta
        /// </summary>
        /// <param name="c"></param> 
        /// <param name="dia"></param> 
        /// <returns></returns>
        public static bool RegistaConsulta(Consultas cons, int dia)
        {
            if(consulta.ContainsKey(dia))
            {
                return true;
            }
            else
            {
                consulta.Add(dia, new List<Consulta>());
            }
            return false;
        }

        /// <summary>
        /// Função para verificar se existe uma determinada consulta
        /// para verificar vai comparar o id da consulta
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool ExisteConsulta(int id)
        {
            //Ver se o dictionary foi inicializado
            if (consulta == null)
            {
                return false;
            }

            foreach (var pair in consulta)
            {
                List<Consulta> listConsultas = pair.Value;

                foreach (Consulta cons in listConsultas)
                {
                    if (cons.idConsulta == id) { 
                        return true;
                    }
                }
            }
            return false;
        }

        //FAZER AS FUNÇÕES DE Remover, ler e guardar(e carregar)


    }

}
