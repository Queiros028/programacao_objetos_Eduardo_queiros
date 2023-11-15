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

namespace clinicaDentario_23005
{
    public class Medico: Pessoa
    {
        #region Atributos
        private Especialidade tipoEspecialidade;
        private int salario;
        private string horarioTrabalho; //variavel para dizer se um determinado medico trabalha numa determinada altura...
        #endregion


        #region Métodos

        #region Construtores


        #endregion

        #region Propriedades

        #endregion

        #region Outros Metodos

        #endregion

        #endregion
    }
}
