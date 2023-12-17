using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum CargoFuncionario
{
    ASSISTENTE,
    RECECIONISTA
}


namespace Pessoas
{
    public class Funcionario : Pessoa
    {
        #region Atributos

        #endregion

        private CargoFuncionario cargo;
        private int numTelef;
        private string horario;
        private int salario;


        #region Métodos

        #region Construtores
        /// <summary>
        /// Parametros default
        /// </summary>
        public Funcionario()
        {
            cargo = CargoFuncionario.ASSISTENTE;
            numTelef = 912345678;
            horario = " ";
            salario = 900;
        }

        public Funcionario(CargoFuncionario CargoFunc, int NumTeleFuncionario, string HorarioFunc, int SalarioFunc)
        {
            cargo = CargoFunc;
            numTelef = NumTeleFuncionario;
            horario = HorarioFunc;
            salario = SalarioFunc;
        }

        #endregion

        #region Propriedades

        public CargoFuncionario cargoFunc
        {
            get { return cargoFunc; }
            set { cargoFunc = value; }
        }

        #endregion

        #region Outros Metodos

        #endregion

        #endregion
    }
}
