/*
 *Validações
 *Autor: Eduardo Queirós, nº 23005
 *
 */
namespace Validacoes
{
    public class Validacoes
    {

        public Validacoes() 
        { 

        }
        /// <summary>
        /// Validacao para o nome 
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static bool NomePossivel(string nome)
        {
            // Verifica se o comprimento do nome está entre 1 e 120 caracteres
            return !string.IsNullOrEmpty(nome) && nome.Length <= 120;
        }


    }
}
