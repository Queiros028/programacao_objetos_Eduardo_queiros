using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
/**
 * Declaração dos dados das consultas
 */


/// <summary>
/// enumerado tipo de tratamanento que pode ser realizado durante uma consulta
/// </summary>
public enum TipoTratamento
{
    ORTODONTIA,
    BRANQUEAMENTO, //branqueamento do dente do utente
    RESTAURACAO, //restauraçao do dente do utente
    DESVITALIZACAO //desvitalização do dente do utente
}

namespace ObjetosNegocio
{
    [Serializable]
    public class Consulta 
    {
        #region Atributos

        [NonSerialized]
        private static int id;
        private static int codConsulta;
        private TipoTratamento tipoTrat;
        //private TipoPagamento tipoPag;
        private DateTime dataConsulta;
        private int duracao; //em minutos


        #endregion


        #region Métodos

        #region Construtores
        
        /// <summary>
        /// Construtor para os atributos static
        /// </summary>
        static Consulta()
        {
            id = 1;
            codConsulta = 1;
        }


        /// <summary>
        ///Construtor Consulta
        /// </summary>
        /// <param name="idConsulta"></param>
        /// <param name="tipoTratamento"></param>
        /// <param name="dataCons"></param>
        /// <param name="duracaoConsulta"></param>
        public Consulta(TipoTratamento tipoTratamento, DateTime dataCons, int duracaoConsulta)
        {
            id = codConsulta++;
            this.tipoTrat = tipoTratamento;
            //this.tipoPag = tipoPagamento;
            this.dataConsulta = dataCons;
            this.duracao = duracaoConsulta;
        }

        #endregion

        #region Propriedades
        /// <summary>
        /// Propriedade para o id da consulta
        /// </summary>
        public static int Id
        {
            get { return id; }
        }

        /// <summary>
        /// Propriedade para o codigo da consulta
        /// </summary>
        public static int CodConsulta
        {
            get { return codConsulta; }
        }


        /// <summary>
        /// Propriedade para o tipo de tratamento
        /// </summary>
        public TipoTratamento tipoTratamento
        {
            get { return tipoTratamento; }
            set { tipoTratamento = value; }
        }
    

        /// <summary>
        /// Propriedade para a data da consulta
        /// </summary>
        public DateTime DataConsulta
        {
            get { return dataConsulta; }
            set { dataConsulta = value; }
        }
        /// <summary>
        /// Propriedade para a duracao da consulta
        /// </summary>
        public int DuracaoConsulta
        {
            get { return duracao; }
            set { duracao = value; }
        }


        #endregion

        #region Override

        /// <summary>
        /// Formato dos dados da consulta ao ser "chamado"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Consulta: Id {0} Duracao {1} Data realizacao {2} Tipo de tratamento {3}", id, duracao, dataConsulta, tipoTratamento);
        }

        /// <summary>
        /// Comparar se dois objetos consulta sao iguais
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Consulta))
            {
                return false;
            }

            Consulta aux = (Consulta)obj;
            if (this.tipoTratamento == aux.tipoTratamento && this.duracao == aux.duracao)
            {
                return true;
            }
            return false;
            throw new Exception("nao e possivel inserir visto que nao e consulta");
        }

        /// <summary>
        /// Calcula o código Hash
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return id.GetHashCode(); // Ou qualquer outra lógica para gerar um código hash único para a instância
        }
        #endregion

        #region Operadores
        public static bool operator ==(Consulta c1, Consulta c2)
        {
            if ((c1.tipoTratamento == c2.tipoTratamento) && (c1.dataConsulta == c2.dataConsulta) && (c1.duracao == c2.duracao))
            {
                return true;
            }
            return false;

        }

        public static bool operator !=(Consulta c1, Consulta c2)
        {
            return !(c1 == c2);
        }
        #endregion

        #region Outros Metodos       


        #endregion

        #endregion
    }
}
