/*
 *Gestão das consultas
 *Autor: Eduardo Queirós, nº 23005
 *
 */
using System;
using System.Runtime.Serialization.Formatters.Binary;
using ObjetosNegocio;

namespace Dados
{
    public class Consultas
    {
        //dictionary de Consulta que foi criada em ObjetosNegocio
        static Dictionary<int, List<Consulta>> consulta = new Dictionary<int, List<Consulta>>();

        /// <summary>
        /// Inicializar dictionary consulta
        /// </summary>
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
            if (consulta.ContainsKey(dia))
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
                    if (cons.idConsulta == id)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //FAZER AS FUNÇÕES DE ler 

        /// <summary>
        /// Guardar as consultas num ficheiro Binário
        /// </summary>
        /// <param name="pessoa"></param>
        /// <param name="caminhoFicheiro"></param>
        public static void GuardaConsultaBinario(Dictionary<int, List<Consulta>> consulta, string caminhoFicheiroConsulta)
        {
            using (FileStream stream = new FileStream(caminhoFicheiroConsulta, FileMode.Create))
            {
                //Cria um BinaryFormatter para serialização do dictionary
                BinaryFormatter formatter = new BinaryFormatter();

                //Serizalização do dictionary no arquivo
                formatter.Serialize(stream, consulta);
            }
        }
        /// <summary>
        /// Carregar ficheiro binário das Consultas
        /// </summary>
        /// <param name="caminhoFicheiro"></param>
        /// <returns></returns>
        public static Dictionary<int, List<Consulta>> CarregarConsultaFicheiroB(string caminhoFicheiroConsulta)
        {
            // Verifica se o arquivo existe antes de tentar carregar
            if (File.Exists(caminhoFicheiroConsulta))
            {
                // Cria um FileStream para ler o arquivo binário
                using (FileStream stream = new FileStream(caminhoFicheiroConsulta, FileMode.Open))
                {
                    // Cria um BinaryFormatter para desserializar o dicionário
                    BinaryFormatter formatter = new BinaryFormatter();

                    // Desserializa o dicionário do arquivo
                    return (Dictionary<int, List<Consulta>>)formatter.Deserialize(stream);
                }
            }
            else
            {
                return new Dictionary<int, List<Consulta>>();
            }
        }

        /// <summary>
        /// Remover Consultas do Dictionay
        /// </summary>
        /// <param name="pessoa"></param>
        /// <param name="chave"></param>
        public static void RemoverConsulta(Dictionary<int, List<Consulta>> consulta, int chave)
        {
            // Verifica se a chave existe no dicionário antes de remover
            if (consulta.ContainsKey(chave))
            {
                // Remove a chave do dicionário
                consulta.Remove(chave);
            }
            else
            {
                Console.WriteLine("A chave '{chave}' não existe no dicionário. Não é possível remover.", chave);
            }
        }


    }

}
