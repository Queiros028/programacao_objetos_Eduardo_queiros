using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.ConstrainedExecution;
using ObjetosNegocio;
/*
 * Funções de inserir, existe, guardar, carregar, remover e ver para os utilizadores da clinica(utentes, funcionarios, medicos) 
 */
namespace Dados
{
    [Serializable]
    public class UtilizadorClinica
    {
        [NonSerialized]
        //dictionarys que foram criados em ObjetosNegocio
        //static Dictionary<int, List<Pessoa>> pessoa;
        static Dictionary<int, List<Utente>> utente;
        static Dictionary<int, List<Funcionario>> funcionario;
        static Dictionary<int, List<Medico>> medico;

        static Dictionary<int, List<Utente>> duplicadoUtente;
        static Dictionary<int, List<Funcionario>> duplicadoFuncionario;
        static Dictionary<int, List<Medico>> duplicadoMedico;


        /// <summary>
        /// Inicializar dictionary de utilizadores
        /// </summary>       
        static UtilizadorClinica()
        {
            //pessoa = new Dictionary<int, List<Pessoa>>();
            utente = new Dictionary<int, List<Utente>>();
            funcionario = new Dictionary<int, List<Funcionario>>();
            medico = new Dictionary<int, List<Medico>>();

            duplicadoUtente = new Dictionary<int, List<Utente>>();
            duplicadoFuncionario = new Dictionary<int, List<Funcionario>>();
            duplicadoMedico = new Dictionary<int, List<Medico>>();

        }

        /// <summary>
        /// Copiar o dictionary de Utente
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, List<Utente>> DictionaryU()
        {
            duplicadoUtente = utente.ToDictionary(entry => entry.Key, entry => entry.Value);
            return duplicadoUtente;
        }

        /// <summary>
        /// Copiar o dictionary de Funcionario
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, List<Funcionario>> DictionaryF()
        {
            duplicadoFuncionario = funcionario.ToDictionary(entry => entry.Key, entry => entry.Value);
            return duplicadoFuncionario;
        }

        /// <summary>
        /// Copiar o dictionary de Medico
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, List<Medico>> DictionaryM()
        {
            duplicadoMedico = medico.ToDictionary(entry => entry.Key, entry => entry.Value);
            return duplicadoMedico;
        }

        // FALTA FUNCAO PARA VER OS DICTIONARY

        #region funcoes para pessoas
        ///// <summary>
        ///// Funcao para inserir pessoas
        ///// </summary>
        ///// <param name="p"></param>
        ///// <param name="dia"></param>
        ///// <returns></returns>
        //public static bool InserePessoa(Pessoa p, int id)
        //{

        //    if (!pessoa.ContainsKey(id))
        //    {
        //        pessoa.Add(id, new List<Pessoa>());
        //    }
        //    if (!pessoa[id].Contains(p))
        //    {
        //        pessoa[id].Add(p);
        //        return true;
        //    }
        //    return false;
        //}

        ///// <summary>
        ///// Funcao para verificar se existem essas pessoas
        ///// para verificar vai comparar pelo nome
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public static bool ExistePessoa(string nome)
        //{
        //    //Ver se o dictionary foi inicializado
        //    if (pessoa == null)
        //    {
        //        return false;
        //    }

        //    foreach (var pair in pessoa)
        //    {
        //        List<Pessoa> listPessoas = pair.Value;

        //        foreach (Pessoa p in listPessoas)
        //        {
        //            if (p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}

        ////FAZER AS FUNÇÕES DE Remover, ler e guardar(e carregar)

        ///// <summary>
        ///// Guarda pessoas num ficheiro binario
        ///// </summary>
        ///// <param name="nomeFicheiro"></param>
        ///// <returns></returns>
        //public static bool GuardaPessoaBinario(string nomeFicheiro)
        //{

        //    try
        //    {
        //        Stream stream = File.Open(nomeFicheiro, FileMode.OpenOrCreate);
        //        BinaryFormatter bin = new BinaryFormatter();
        //        bin.Serialize(stream, pessoa);
        //        stream.Close();
        //        return true;

        //    }
        //    catch (IOException e)
        //    {
        //        Console.WriteLine("Erro: " + e.Message);
        //        throw e;
        //    }
        //}
        ///// <summary>
        ///// Carregar ficheiro binario para pessoas
        ///// </summary>
        ///// <param name="nomeFicheiro"></param>
        ///// <returns></returns>
        //public static bool CarregarPessoaFicheiroB(string nomeFicheiro)
        //{

        //    if (File.Exists(nomeFicheiro) && (new FileInfo(nomeFicheiro).Length > 0))
        //    {
        //        try
        //        {
        //            Stream stream = File.Open(nomeFicheiro, FileMode.Open);
        //            BinaryFormatter bin = new BinaryFormatter();
        //            pessoa = (Dictionary<int, List<Pessoa>>)bin.Deserialize(stream);
        //            stream.Close();
        //            return true;
        //        }
        //        catch (FileLoadException e)
        //        {
        //            Console.Write("Erro ao carregar o ficheiro..." + e.Message);
        //            throw e;
        //        }
        //    }
        //    return false;
        //}



        ///// <summary>
        ///// Função para remover num dictionary
        ///// </summary>
        ///// <param name="dicionario"></param>
        ///// <param name="chave"></param>
        //public static bool RemoverPessoa(Pessoa p, string nome)
        //{
        //    if (pessoa.ContainsValue(nome))
        //    {
        //        if (pessoa[id].Contains(p))
        //        {
        //            pessoa[id].Remove(p);
        //            return true;
        //        }
        //        throw new Exception("O registo remover pessoa nao existe");
        //    }
        //    return false;
        //}

        #endregion

        #region funcoes para utentes
        /// <summary>
        /// Inserir utentes
        /// </summary>
        /// <param name="u"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool InsereUtente(Utente u, int id)
        {

            if (!utente.ContainsKey(id))
            {
                utente.Add(id, new List<Utente>());
            }
            if (!utente[id].Contains(u))
            {
                utente[id].Add(u);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Funcao para verificar se existem esses utentes
        /// </summary>
        /// <param name="u"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static bool ExisteUtente(string nome)
        {
            //Ver se o dictionary foi inicializado
            if (utente == null)
            {
                return false;
            }

            foreach (var pair in utente)
            {
                List<Utente> listUtente = pair.Value;

                foreach (Utente u in listUtente)
                {
                    if (u.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        /// <summary>
        /// Guarda utentes num ficheiro binario
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool GuardaUtenteBinario(string nomeFicheiro)
        {

            try
            {
                Stream stream = File.Open(nomeFicheiro, FileMode.OpenOrCreate);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, utente);
                stream.Close();
                return true;

            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
                throw e;
            }
        }

        /// <summary>
        /// Carregar o ficheiro binario dos utentes
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool CarregarUtenteFicheiroB(string nomeFicheiro)
        {

            if (File.Exists(nomeFicheiro) && (new FileInfo(nomeFicheiro).Length > 0))
            {
                try
                {
                    Stream stream = File.Open(nomeFicheiro, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    utente = (Dictionary<int, List<Utente>>)bin.Deserialize(stream);
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
        /// Função para remover num dictionary
        /// </summary>
        /// <param name="utente"></param>
        /// <param name="chave"></param>
        public static bool RemoverUtente(Utente u, int id)
        {
            if (utente.ContainsKey(id))
            {
                if (utente[id].Contains(u))
                {
                    utente[id].Remove(u);
                    return true;
                }
                throw new Exception("O registo remover utente nao existe");
            }
            return false;
        }

        /// <summary>
        /// Ver o dictionary de utente
        /// </summary>
        public static void VerDictionaryU()
        {
            UtilizadorClinica.DictionaryU();
            foreach (KeyValuePair<int, List<Utente>> entry in duplicadoUtente)
            {
                Console.WriteLine($"ID: {entry.Key}");
                foreach (Utente utente in entry.Value)
                {
                    Console.WriteLine(" " + utente.ToString());
                }
            }
        }

        #endregion

        #region funcoes para funcionarios
        /// <summary>
        /// Funcao para inserir funcionarios
        /// </summary>
        /// <param name="f"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool InsereFuncionario(Funcionario f, int id)
        {

            if (!funcionario.ContainsKey(id))
            {
                funcionario.Add(id, new List<Funcionario>());
            }
            if (!funcionario[id].Contains(f))
            {
                funcionario[id].Add(f);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Funcao para verificar se existem esses funcionarios
        /// </summary>
        /// <param name="f"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static bool ExisteFuncionario(string nome)
        {
            // Ver se o dictionary foi inicializado
            if (funcionario == null)
            {
                return false;
            }

            foreach (var pair in funcionario)
            {
                List<Funcionario> listFuncionario = pair.Value;

                foreach (Funcionario f in listFuncionario)
                {
                    if (f.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        /// <summary>
        /// Guarda funcionarios num ficheiro binario
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool GuardaFuncionarioBinario(string nomeFicheiro)
        {

            try
            {
                Stream stream = File.Open(nomeFicheiro, FileMode.OpenOrCreate);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, funcionario);
                stream.Close();
                return true;

            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
                throw e;
            }
        }
        /// <summary>
        /// Carregar ficheiro binario dos funcionarios
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool CarregarFuncionarioFicheiroB(string nomeFicheiro)
        {

            if (File.Exists(nomeFicheiro) && (new FileInfo(nomeFicheiro).Length > 0))
            {
                try
                {
                    Stream stream = File.Open(nomeFicheiro, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    funcionario = (Dictionary<int, List<Funcionario>>)bin.Deserialize(stream);
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
        /// Função para remover funcionario num dictionary
        /// </summary>
        /// <param name="funcionario"></param>
        /// <param name="chave"></param>
        public static bool RemoverFuncionario(Funcionario f, int id)
        {
            if (funcionario.ContainsKey(id))
            {
                if (funcionario[id].Contains(f))
                {
                    funcionario[id].Remove(f);
                    return true;
                }
                throw new Exception("O registo remover pessoa nao existe");
            }
            return false;
        }
        /// <summary>
        /// Ver dictionary de funcionario
        /// </summary>
        public static void VerDictionaryF()
        {
            UtilizadorClinica.DictionaryF();
            foreach (KeyValuePair<int, List<Funcionario>> entry in duplicadoFuncionario)
            {
                Console.WriteLine($"ID: {0}", entry.Key);
                foreach (Funcionario funcionario in entry.Value)
                {
                    Console.WriteLine(" " + funcionario.ToString());
                }
            }
        }

        #endregion

        #region funcoes para medicos
        /// <summary>
        /// Funcao para inserir medicos
        /// </summary>
        /// <param name="m"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool InsereMedico(Medico m, int id)
        {

            if (!medico.ContainsKey(id))
            {
                medico.Add(id, new List<Medico>());
            }
            if (!medico[id].Contains(m))
            {
                medico[id].Add(m);
                return true;
            }
            return false;
        }

        /// <summary>
        /// uncao para verificar se existem esses medicos
        /// </summary>
        /// <param name="m"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static bool ExisteMedico(string nome)
        {
            // Ver se o dictionary foi inicializado
            if (medico == null)
            {
                return false;
            }

            foreach (var pair in medico)
            {
                List<Medico> listMedico = pair.Value;

                foreach (Medico m in listMedico)
                {
                    if (m.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Guarda medicos num ficheiro binario
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool GuardaMedicoBinario(string nomeFicheiro)
        {

            try
            {
                Stream stream = File.Open(nomeFicheiro, FileMode.OpenOrCreate);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, medico);
                stream.Close();
                return true;

            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
                throw e;
            }
        }
        /// <summary>
        /// Carregar ficheiro dos medicos
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool CarregarMedicoFicheiroB(string nomeFicheiro)
        {

            if (File.Exists(nomeFicheiro) && (new FileInfo(nomeFicheiro).Length > 0))
            {
                try
                {
                    Stream stream = File.Open(nomeFicheiro, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    medico = (Dictionary<int, List<Medico>>)bin.Deserialize(stream);
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
        /// Função para remover medico num dictionary
        /// </summary>
        /// <param name="funcionario"></param>
        /// <param name="chave"></param>
        public static bool RemoverMedico(Medico m, int id)
        {
            if (medico.ContainsKey(id))
            {
                if (medico[id].Contains(m))
                {
                    medico[id].Remove(m);
                    return true;
                }
                throw new Exception("O registo remover pessoa nao existe");
            }
            return false;
        }

        /// <summary>
        /// Ver dictionary de Medico
        /// </summary>
        public static void VerDictionaryM()
        {
            UtilizadorClinica.DictionaryM();
            foreach (KeyValuePair<int, List<Medico>> entry in duplicadoMedico)
            {
                Console.WriteLine($"ID: {0}", entry.Key);
                foreach (Medico medico in entry.Value)
                {
                    Console.WriteLine(" " + medico.ToString());
                }
            }
        }


        #endregion

    }
}