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

namespace Pessoas
{
    public class Pessoa
    {
        #region Atributos
        private string nome;
        private DescricaoPessoa descricao;
        private static int cod; //esta variavel vai ser a que vai identificar cada pessoa na clinica
        private int codGlobal;

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
            descricao = DescricaoPessoa.UTENTE;
            //descricao = DescricaoPessoa.MEDICO;
            //descricao = DescricaoPessoa.FUNCIONARIO;            
        }
        public Pessoa(string Nome, DescricaoPessoa descricaoP, int codGlob, DescricaoPessoa tipoP)
        {
            nome = Nome;
            descricao = descricaoP;
            codGlobal = codGlob;
            tipo = tipoP;
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
