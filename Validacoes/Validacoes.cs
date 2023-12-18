namespace Validacoes
{
    public class Validacoes
    {

        public Validacoes() 
        { 

        }

        public static bool NomePossivel(string nome)
        {
            // Verifica se o comprimento do nome está entre 1 e 120 caracteres
            return !string.IsNullOrEmpty(nome) && nome.Length <= 120;
        }


    }
}
