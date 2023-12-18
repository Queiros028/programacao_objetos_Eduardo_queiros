/*
 *"Parâmetros" de cada consulta
 *Autor: Eduardo Queirós, nº 23005
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
    public class Consulta : IComparable
    {

        #region Atributos
        //para ja tenho estas variaveis, dps ver se é preciso colocar mais ou n
        private int id;
        private TipoTratamento tipoTrat;
        private TipoPagamento tipoPag;
        private DateTime dataConsulta;
        private int duracao; //em minutos


        #endregion


        #region Métodos

        #region Construtores
        /// <summary>
        /// Construtor parametros default
        /// </summary>
        public Consulta()
        {
            id = 0;
            tipoTrat = TipoTratamento.ORTODONTIA;
            //tipoTrat = TipoTratamento.BRANQUEAMENTO;
            //tipoTrat = TipoTratamento.RESTAURACAO;
            //tipoTrat = TipoTratamento.DESVITALIZACAO;
            tipoPag = TipoPagamento.DINHEIRO;
            //tipoPag = TipoPagamento.CARTAO;
            //tipoPag = TipoPagamento.CHEQUE;
            dataConsulta = DateTime.Now;
            duracao = 30;

        }
        /// <summary>
        /// Construtor Consulta
        /// </summary>
        /// <param name="idConsulta"></param>
        /// <param name="tipoTratamento"></param>
        /// <param name="tipoPagamento"></param>
        /// <param name="duracaoConsulta"></param>
        public Consulta(int idConsulta, TipoTratamento tipoTratamento, TipoPagamento tipoPagamento, int duracaoConsulta)
        {
            id = idConsulta;
            tipoTrat = tipoTratamento;
            tipoPag = tipoPagamento;
            dataConsulta = DateTime.Today;
            duracao = duracaoConsulta;
        }
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
            id = idConsulta;
            tipoTrat = tipoTratamento;
            tipoPag = tipoPagamento;
            dataConsulta = dataCons;
            duracao = duracaoConsulta;
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
            return string.Format("Consulta: Id {0}\n Tipo tratamento {1}\n Duracao {2}\n Data realizacao {3}\n Tipo de pagamento {4}\n", id, duracao, dataConsulta, tipoPagamento);
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
            if (id == aux.id && tipoTratamento == aux.tipoTratamento && duracao == aux.duracao && tipoPagamento == aux.tipoPagamento)
            {
                return true;
            }
            return false;
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

                //if (aux.nome > this.nome)
                //if(aux.nome.CompareTo(this.nome))
                //if(String.Compare(aux.nome,this.nome))
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