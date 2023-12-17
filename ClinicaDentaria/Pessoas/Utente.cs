using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoas
{
    public class Utente : Pessoa
    {
        #region Atributos
        //verificar se estes atributos dps vao ser public ou n... n tenho a certeza se vou ligar esta classe à classe Consulta...

        private string mail;
        private int numTelef;
        DateTime dataNasc;
        static int numCartaoSaude; //meti static pq cada utente vai ter um codigo cartao de saude que vai ser necessário para a identificação na clínica
        #endregion


        #region Métodos

        #region Construtores
        static Utente()
        {
            numCartaoSaude = 0;
        }
        /// <summary>
        /// parametros default
        /// </summary>
        public Utente()
        {
            mail = " ";
            numTelef = 987654321;
            //dataNasc = DateTime.Now; -> VER COMO FAZER PARA APARECER A DATA DE NASCIMENTO DA PESSOA
            numCartaoSaude++;
        }
        public Utente(string Mail, int NumTelefUtente, DateTime DataNascUtente)
        {
            mail = Mail;
            numTelef = NumTelefUtente;
            dataNasc = DataNascUtente;
        }


        #endregion

        #region Propriedades
        //ver como fzr para a parte do num de cartao de saude
        public string Mail
        {
            set { mail = value; }
            get { return mail; }
        }

        public int NumTelefUtente
        {
            set { NumTelefUtente = value; }
            get { return NumTelefUtente; }
        }

        #endregion

        #region Outros Metodos

        #endregion

        #endregion
    }
}
