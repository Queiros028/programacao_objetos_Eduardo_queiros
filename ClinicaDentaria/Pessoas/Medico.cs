using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public enum Especialidade
{
    ORTODONTIA,
    BRANQUEAMENTO, //branqueamento do dente do utente
    RESTAURACAO, //restauraçao do dente do utente
    DESVITALIZACAO //desvitalização do dente do utente
}

namespace Pessoas
{
    public class Medico : Pessoa
    {
        #region Atributos
        private Especialidade tipoEspecialidade;
        private int salario;
        private string horarioTrabalho; //variavel para dizer se um determinado medico trabalha numa determinada altura...(ex: trabalha segunda a sexta)
        #endregion


        #region Métodos

        #region Construtores
        /// <summary>
        /// Parâmetros default
        /// </summary>
        public Medico()
        {
            //tipoEspecialidade = tipo;
            salario = 1000;
            horarioTrabalho = " ";
            tipoEspecialidade = Especialidade.ORTODONTIA;
            //tipoEspecialidade = Especialidade.BRANQUEAMENTO;
            //tipoEspecialidade = Especialidade.RESTAURACAO;
            //tipoEspecialidade = Especialidade.DESVITALIZACAO;

        }
        /*
        public Medico(Especialidade tipoEsp, int SalarioMedico, string horarioTrabMedico)
        {
            tipo = tipoEsp;
            salario = SalarioMedico;
            horarioTrabalho = horarioTrabMedico;
        }*/

        #endregion

        #region Propriedades


        #endregion

        #region Outros Metodos

        #endregion

        #endregion
    }
}

