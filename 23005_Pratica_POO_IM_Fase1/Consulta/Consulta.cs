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
namespace clinicaDentario_23005
{
    //nao tenho a certeza se consulta herdar de utente esta correto...
    public class Consulta: Utente //tambem estava a pensar que consulta herdasse de medico
    {

        #region Atributos
        //para ja tenho estas variaveis, dps ver se é preciso colocar mais ou n
        private int id;
        private TipoTratamento tipoTrat;
        private TipoPagamento tipoPag;
        private DateTime dataConsulta;
       


        #endregion


        #region Métodos

        #region Construtores

        public Consulta()
        {
            id = 0;
            tipoTrat = TipoTratamento.ORTODONTIA;
            tipoTrat = TipoTratamento.BRANQUEAMENTO;
            tipoTrat = TipoTratamento.RESTAURACAO;
            tipoTrat = TipoTratamento.DESVITALIZACAO;
            tipoPag = TipoPagamento.DINHEIRO;
            tipoPag = TipoPagamento.CARTAO;
            tipoPag = TipoPagamento.CHEQUE;

        }

        public Consulta(int idConsulta, TipoTratamento tipoTratamento, TipoPagamento tipoPagamento)
        {
            id = idConsulta;
            tipoTrat = tipoTratamento;
            tipoPag = tipoPagamento;
        }

        #endregion

        #region Propriedades

        public int Id
        {
            get { return id; }
        }

        public TipoTratamento TipoTrat
        {
            get { return tipoTrat; }
            set { tipoTrat = value; }
        }

        public TipoPagamento TipoPag
        {
            get { return tipoPag; }
            set { tipoPag = value; }
        }

        #endregion

        #region Outros Metodos

        #endregion

        #endregion
    }
}
