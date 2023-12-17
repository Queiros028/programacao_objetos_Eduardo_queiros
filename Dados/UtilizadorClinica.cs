using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class UtilizadorClinica
    {
        //dictionary de Pessoas que foi criada em ObjetosNegocio
        static Dictionary<int, List<Pessoa>> pessoa = new Dictionary<int, List<Pessoa>>();

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
        public static bool InserePessoa(Pessoa p, int dia)
        {
            if (pessoa.ContainsKey(dia))
            {
                return true;
            }
            else
            {
                pessoa.Add(dia, new List<Pessoa>());
            }
            return false;
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

    }
}