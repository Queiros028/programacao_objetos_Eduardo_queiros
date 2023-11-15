using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum DescricaoPessoa
{
    UTENTE,
    FUNCIONARIO,
    MEDICO
}

namespace clinicaDentario_23005
{
     public class Pessoa
    {
        #region Atributos
        public string nome;
        public DescricaoPessoa descricao;
        static int cod; //esta variavel vai ser a que vai identificar cada pessoa na clinica
        public int codGlobal;

        #endregion

        #region Métodos

        #region Construtores
        /// <summary>
        /// Construtor de classe: Inicializa variaveis
        /// </summary>
        static Pessoa()
        {
            cod = 1;
        }

        public Pessoa()
        {
            nome = "";
            descricao = tipo;
            codGlobal = cod;
            cod++;
        }

        #endregion

        #region Propriedades
        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        public DescricaoPessoa tipo
        {
            get { return descricao; }
            set { descricao = value; }
        }

        #endregion

        #region override
        public override string ToString()
        {
            return String.Format("Ficha da Pessoa-> Nome: {0}; Funcao: {1} ; codigo {2}\n", nome, descricao, codGlobal);
        }

        #endregion


        #region Outros Metodos

        #endregion

        #endregion
    }
}
