using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ObjetosNegocio;
using System.Net.NetworkInformation;

/*
 * Funções de inserir, existe, guardar, carregar, remover e ver para consultas 
 */
namespace Dados
{
    [Serializable]
    public class Consultas
    {
        //dictionary de Consulta que foi criada em ObjetosNegocio
        [NonSerialized]
        static Dictionary<int, List<Consulta>> consulta;

        static Dictionary<int, List<Consulta>> duplicadoConsulta;

        /// <summary>
        /// Inicializar dictionary consulta
        /// </summary>
        static Consultas()
        {
            consulta = new Dictionary<int, List<Consulta>>();
            duplicadoConsulta = new Dictionary<int, List<Consulta>>();
        }

        /// <summary>
        /// Copia dictionary de consultas
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, List<Consulta>> DictionaryC()
        {
            duplicadoConsulta = consulta.ToDictionary(entry => entry.Key, entry => entry.Value);
            return duplicadoConsulta;
        }

        /// <summary>
        /// Insere uma consulta
        /// </summary>
        /// <param name="cons"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool RegistaConsulta(Consulta cons, int id)
        {
            // Certifique-se de que a chave id existe no dicionário
            if (!consulta.ContainsKey(id))
            {
                consulta.Add(id, new List<Consulta>());
            }

            // Verifique se a consulta já existe na lista associada à chave id
            if (!consulta[id].Contains(cons))
            {
                consulta[id].Add(cons);
                return true;
            }

            return false;


        }

        /// <summary>
        /// Função para verificar se existe uma determinada consulta
        /// para verificar vai comparar o id da consulta
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool ExisteConsulta(int id, Consulta cons)
        {
            //Ver se o dictionary foi inicializado
            if (consulta == null)
            {
                return false;
            }

            if (consulta.ContainsKey(id))
                consulta.Add(id, new List<Consulta>());
            if (!consulta[id].Contains(cons))
            {
                consulta[id].Add(cons);
                return true;

            }
            return false;
        }

        //FAZER AS FUNÇÕES DE ler 

        /// <summary>
        /// Guardar as consultas num ficheiro Binário
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool GuardaConsultaBinario(string nomeFicheiro)
        {
            try
            {
                Stream stream = File.Open(nomeFicheiro, FileMode.OpenOrCreate);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, consulta);
                stream.Close();
                return true;
            }
            catch (IOException e)
            {
                Console.Write("Erro ao guardar o ficheiro...:" + e.Message);
                throw e;
            }
        }
        /// <summary>
        /// lê as consultas num ficheiro Binário
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool CarregarConsultaFicheiroB(string nomeFicheiro)
        {

            if (File.Exists(nomeFicheiro) && (new FileInfo(nomeFicheiro).Length > 0))
            {
                try
                {
                    Stream stream = File.Open(nomeFicheiro, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    consulta = (Dictionary<int, List<Consulta>>)bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch (FileLoadException e)
                {
                    Console.Write("Erro ao carregar o ficheiro..." + e.Message);
                    throw e;
                }
            }
            return false;
        }

        /// <summary>
        /// Remover Consultas do Dictionay
        /// </summary>
        /// <param name="pessoa"></param>
        /// <param name="chave"></param>
        public static bool RemoverConsulta(Consulta cons, int id)
        {
            // Verifica se a chave existe no dicionário antes de remover
            if (consulta.ContainsKey(id))
            {
                // Remove a chave do dicionário
                consulta.Remove(id);
            }
            else
            {
                Console.WriteLine("A chave '{chave}' não existe no dicionário. Não é possível remover.", id);
            }
            return false;
        }

        /// <summary>
        /// Ver dictionary de Medico
        /// </summary>
        public static void VerDictionaryC()
        {
            Consultas.DictionaryC();
            foreach (KeyValuePair<int, List<Consulta>> entry in duplicadoConsulta)
            {
                Console.WriteLine($"ID: {entry.Key}");
                foreach (Consulta c in entry.Value)
                {
                    Console.WriteLine(" " + c.ToString());
                }
            }
        }

    }
}
