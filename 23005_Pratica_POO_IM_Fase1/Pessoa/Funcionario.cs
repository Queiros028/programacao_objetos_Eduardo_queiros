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


namespace clinicaDentario_23005
{
    public class Funcionario: Pessoa
    {
        #region Atributos

        #endregion

        public CargoFuncionario cargo;
        private int numTelef;
        private string horario;
        private int salario;


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
