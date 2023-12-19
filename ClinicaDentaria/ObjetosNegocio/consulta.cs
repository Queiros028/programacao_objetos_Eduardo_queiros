/*
 *"Parâmetros" de cada consulta
 *Autor: Eduardo Queirós, nº 23005
 *
 */
using System;
using System.IO;
using System.Text;

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
/// <summary>
/// Tipo de pagamento disponivel para pagar a consulta
/// </summary>
public enum TipoPagamento
{
    DINHEIRO,
    CARTAO,
    CHEQUE
}
namespace ObjetosNegocio
{
    [Serializable]
    public class Consulta : IComparable
    {

        #region Atributos

        [NonSerialized]
        private int id;
        private TipoTratamento tipoTrat;
        private TipoPagamento tipoPag;
        private DateTime dataConsulta;
        private int duracao; //em minutos


        #endregion


        #region Métodos

        #region Construtores

        /// <summary>
        ///Construtor Consulta
        /// </summary>
        /// <param name="idConsulta"></param>
        /// <param name="tipoTratamento"></param>
        /// <param name="tipoPagamento"></param>
        /// <param name="dataCons"></param>
        /// <param name="duracaoConsulta"></param>
        public Consulta(int idConsulta, TipoTratamento tipoTratamento, TipoPagamento tipoPagamento, DateTime dataCons, int duracaoConsulta)
        {
            this.id = idConsulta;
            this.tipoTrat = tipoTratamento;
            this.tipoPag = tipoPagamento;
            this.dataConsulta = dataCons;
            this.duracao = duracaoConsulta;
        }

        #endregion

        #region Propriedades
        /// <summary>
        /// Propriedade para o id da consulta
        /// </summary>
        public int idConsulta
        {
            get { return idConsulta; }
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
        /// Propriedade para o tipo de pagamento
        /// </summary>
        public TipoPagamento tipoPagamento
        {
            get { return tipoPagamento; }
            set { tipoPagamento = value; }
        }

        //Voltar a ver esta propriedade

        /// <summary>
        /// Propriedade para a data da consulta
        /// </summary>
        public DateTime DataConsulta
        {
            get { return dataConsulta; }
            set { dataConsulta = value; }
        }

        #endregion

        #region Override

        /// <summary>
        /// Formato dos dados da consulta ao ser "chamado"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Consulta: Id {0} Tipo tratamento {1} Duracao {2} Data realizacao {3} Tipo de pagamento {4}", id, duracao, dataConsulta, tipoPagamento);
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
            if (this.id == aux.id && this.tipoTratamento == aux.tipoTratamento && this.duracao == aux.duracao && this.tipoPagamento == aux.tipoPagamento)
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
            if ((c1.id == c2.id) && (c1.tipoTratamento == c2.tipoTratamento) && (c1.tipoPagamento == c2.tipoPagamento) && (c1.dataConsulta == c2.dataConsulta) && (c1.duracao == c2.duracao))
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

        /// <summary>
        /// Verificar se o objeto que está é consulta
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int CompareTo(object? obj)
        {
            if (obj.GetType() == typeof(Consulta))
            {
                Consulta aux = (Consulta)obj;
                if (this.id.CompareTo(aux.id) > 0) return 1;
                else
                    if (this.id.CompareTo(aux.id) < 0) return -1;
                return 0;
            }
            else
                throw new Exception("Impossivel");
        }


        #endregion

        #endregion
    }
}