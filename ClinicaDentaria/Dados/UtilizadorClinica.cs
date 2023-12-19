using System.Net;
using System.Runtime.Serialization.Formatters.Binary;

/*
 *Gestão dos utilizadores da clínica
 *Autor: Eduardo Queirós, nº 23005
 *
 */
using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class UtilizadorClinica
    {
        //dictionary de Pessoas que foi criada em ObjetosNegocio
        static Dictionary<int, List<Pessoa>> pessoa = new Dictionary<int, List<Pessoa>>();
        /// <summary>
        /// Inicializar dictionary de utilizadores
        /// </summary>
        public UtilizadorClinica()
        {
            pessoa = new Dictionary<int, List<Pessoa>>();
        }

        /// <summary>
        /// Funcao para inserir pessoas
        /// </summary>
        /// <param name="p"></param>
        /// <param name="dia"></param>
        /// <returns></returns>
        public static bool InserePessoa(Pessoa p, int id)
        {

            if(!pessoa.ContainsKey(id))
            {
                pessoa.Add(id, new List<Pessoa>());
            }
            if (!pessoa[id].Contains(p))
            {
                pessoa[id].Add(p);
                return true;
            }
            return false;


            //if (pessoa.ContainsKey(dia))
            //{
            //    return true;
            //}
            //else
            //{
            //    pessoa.Add(dia, new List<Pessoa>());
            //}
            //return false;
        }

        /// <summary>
        /// Funcao para verificar se existem essas pessoas
        /// para verificar vai comparar pelo nome
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool ExistePessoa(string nome)
        {
            //Ver se o dictionary foi inicializado
            if (pessoa == null)
            {
                return false;
            }

            foreach (var pair in pessoa)
            {
                List<Pessoa> listPessoas = pair.Value;

                foreach (Pessoa p in listPessoas)
                {
                    if (p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //FAZER AS FUNÇÕES DE Remover, ler e guardar(e carregar)

        /// <summary>
        /// Guardar Pessoas num ficheiro de texto em binário
        /// </summary>
        /// <param name="pessoa"></param>
        /// <param name="caminhoFicheiro"></param>
        public static bool GuardaPessoaBinario(string nomeFicheiro)
        {

            try
            {
                Stream stream = File.Open(nomeFicheiro, FileMode.OpenOrCreate);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, pessoa);
                stream.Close();
                return true;

            }catch (IOException e) 
            {
                Console.WriteLine("Erro: "+ e.Message);
                throw e;
            }
        }
        /// <summary>
        /// Carregar ficheiro binário das Pessoas
        /// </summary>
        /// <param name="caminhoFicheiro"></param>
        /// <returns></returns>
        public static Dictionary<int, List<Pessoa>> CarregarFicheiroB(string caminhoFicheiro)
        {
            // Verifica se o arquivo existe antes de tentar carregar
            if (File.Exists(caminhoFicheiro))
            {
                // Cria um FileStream para ler o arquivo binário
                using (FileStream stream = new FileStream(caminhoFicheiro, FileMode.Open))
                {
                    // Cria um BinaryFormatter para desserializar o dicionário
                    BinaryFormatter formatter = new BinaryFormatter();

                    // Desserializa o dicionário do arquivo
                    return (Dictionary<int, List<Pessoa>>)formatter.Deserialize(stream);
                }
            }
            else
            {
                return new Dictionary<int, List<Pessoa>>();
            }
        }

        /// <summary>
        /// Função para remover num dictionary
        /// </summary>
        /// <param name="dicionario"></param>
        /// <param name="chave"></param>
        public static void RemoverPessoa(Dictionary<int, List<Pessoa>> pessoa, int chave)
        {
            // Verifica se a chave existe no dicionário antes de remover
            if (pessoa.ContainsKey(chave))
            {
                // Remove a chave do dicionário
                pessoa.Remove(chave);
            }
            else
            {
                Console.WriteLine("A chave '{chave}' não existe no dicionário. Não é possível remover.", chave);
            }
        }

        public static bool InserePessoa(Pessoa p1)
        {
            throw new NotImplementedException();
        }
    }
}