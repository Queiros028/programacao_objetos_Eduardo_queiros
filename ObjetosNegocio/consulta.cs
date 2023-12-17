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
    public class Consulta: IComparable
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
        /// parametros default
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

        public Consulta(int idConsulta, TipoTratamento tipoTratamento, TipoPagamento tipoPagamento, int duracaoConsulta)
        {
            id = idConsulta;
            tipoTrat = tipoTratamento;
            tipoPag = tipoPagamento;
            dataConsulta = DateTime.Today;
            duracao = duracaoConsulta;
        }
        
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

        public int idConsulta
        {
            get { return idConsulta; }
        }

        public TipoTratamento tipoTratamento
        {
            get { return tipoTratamento; }
            set { tipoTratamento = value; }
        }

        public TipoPagamento tipoPagamento
        {
            get { return tipoPagamento; }
            set { tipoPagamento = value; }
        }

        //Voltar a ver esta propriedade
        public DateTime DataConsulta
        {
            get { return dataConsulta;}
            set { dataConsulta = value; }
        }

        #endregion

        #region Override

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

            Consulta aux =(Consulta)obj;
            if(id == aux.id && tipoTratamento == aux.tipoTratamento && duracao == aux.duracao && tipoPagamento == aux.tipoPagamento)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode(); // Ou qualquer outra lógica para gerar um código hash único para a instância
        }
        #endregion



        #region Outros Metodos

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
