using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


/// <summary>
/// Que tipo de pessoa é
/// </summary>
public enum DescricaoPessoa
{
    UTENTE,// em default funcionario tem codigo 10
    FUNCIONARIO, // em default funcionario tem codigo 20
    MEDICO// em default funcionario tem codigo 30
}
/// <summary>
/// Quando a pessoa é funcionário, escolhe o tipo de funcionário que é
/// </summary>
public enum CargoFuncionario
{
    ASSISTENTE,
    RECECIONISTA
}
/// <summary>
/// Especialidade de um médico
/// </summary>
public enum Especialidade
{
    ORTODONTIA,
    BRANQUEAMENTO, //branqueamento do dente do utente
    RESTAURACAO, //restauraçao do dente do utente
    DESVITALIZACAO //desvitalização do dente do utente
}

namespace ObjetosNegocio
{
    public class Pessoa
    {
        #region Atributos
        private string nome;
        //para poder utilizar esta descrição noutras classes foi necessário colocar protected
        protected DescricaoPessoa descricao;
        /*esta variavel vai ser a que vai identificar cada pessoa na clinica, e como esse codigo vai sempre ser o mesmo, coloquei static pois ao ser static,
         * ao fechar o programa, a memória vai continuar la */
        private static int cod;
        protected int codGlobal;

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

      //ACHO QUE FALTA UMA PARA O CODGLOBAL!!!!!!1

        #endregion

        #region override
        public override string ToString()
        {
            return String.Format("Ficha da Pessoa-> Nome: {0}; Funcao: {1} ; codigo {2}\n", nome, descricao, codGlobal);
        }

        #endregion


        #region Outros Metodos
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Pessoa))
            {
                return false;
            }

            Pessoa aux = (Pessoa)obj;
            //ver se neste if a primeira condição está correta...
            if (cod == aux.codGlobal && System.String.Equals(nome, aux.nome) && descricao == aux.descricao)
            {
                return true;
            }

            return false;
        }

        //ver se nesta esta correta
        public override int GetHashCode()
        {
            return cod.GetHashCode(); // Ou qualquer outra lógica para gerar um código hash único para a instância
        }
        #endregion

        #endregion
    }

    public class Utente : Pessoa
    {
        #region Atributos
        //verificar se estes atributos dps vao ser public ou n... n tenho a certeza se vou ligar esta classe à classe Consulta...

        private string mail;
        private int numTelef;
        /*meti static pq cada utente vai ter um codigo cartao de saude que vai ser necessário para a identificação na clínica
         * (nota: além de terem este codigo tambem têm o codigo que herdam de pessoa)*/
        static int numCartaoSaude;
        #endregion


        #region Métodos

        #region Construtores
        static Utente()
        {
            numCartaoSaude = 0;
        }
        /// <summary>
        /// parametros default
        /// </summary>
        public Utente()
        {
            Nome = "Antonio";
            codGlobal = 10;
            mail = " ";
            numTelef = 987654321;
            numCartaoSaude++;
        }
        public Utente(string nome, int codUtente, string Mail, int NumTelefUtente)
        {
            Nome = nome;
            codGlobal = codUtente;
            mail = Mail;
            numTelef = NumTelefUtente;
            numCartaoSaude++;
        }


        #endregion

        #region Propriedades
        /*
         * nota: nao vou fazer nd para o num de cartao de saude porque quero que n se mexa nisso e que seja o programa a "atibuir" pois tenho o numCartaoSaude++;
         */
        public string Mail
        {
            set { mail = value; }
            get { return mail; }
        }

        public int NumTelefUtente
        {
            set { NumTelefUtente = value; }
            get { return NumTelefUtente; }
        }

        #endregion

        #region Outros Metodos

        #endregion

        #endregion
    }

    public class Funcionario : Pessoa
    {
        #region Atributos

        private CargoFuncionario cargo;
        private int numTelef;
        private int horario; // vai dizer quantos dias por semana trabalha(0 a 7)
        private int salario;

        #endregion


        #region Métodos

        #region Construtores
        /// <summary>
        /// Parametros default
        /// </summary>
        public Funcionario()
        {
            Nome = "Joaquim ";
            codGlobal = 20;
            //descricao = DescricaoPessoa.FUNCIONARIO; -> penso que n faz sentido por isso retirei
            cargo = CargoFuncionario.ASSISTENTE;
            numTelef = 912345678;
            horario = 2;
            salario = 900;
        }

        public Funcionario(string nome, int codigoFunc,CargoFuncionario CargoFunc, int NumTeleFuncionario, int HorarioFunc, int SalarioFunc)
        {
            Nome = nome;
            codGlobal = codigoFunc;
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

        public int NumTelef
        {
            get { return numTelef; } 
            set { numTelef = value; }
        }

        public int Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        public int Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        #endregion

        #region Outros Metodos

        #endregion

        #endregion
    }

    public class Medico : Pessoa
    {
        #region Atributos
        private Especialidade tipoEspecialidade;
        private int salario;
        private int horarioTrabalho; //variavel para dizer quantos dias por semana o medico irá trabalhar(0 a 7)
        #endregion


        #region Métodos

        #region Construtores
        /// <summary>
        /// Parâmetros default
        /// </summary>
        public Medico()
        {
            Nome = "Maria";
            codGlobal = 30;
            salario = 1000;
            horarioTrabalho = 5;
            tipoEspecialidade = Especialidade.ORTODONTIA;
        }
        
        public Medico(string nome, int codMedico, int Salario,int Horario,Especialidade TipoEsp)
        {
            Nome = nome;
            codGlobal = codMedico;  
            salario = Salario;
            horarioTrabalho = Horario;
            tipoEspecialidade = TipoEsp;
        }

        #endregion

        #region Propriedades
        public int Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public int HorarioTrabalho
        {
            get { return horarioTrabalho; }
            set { horarioTrabalho = value; }
        }
        public Especialidade TipoEspecialidade
        {
            get { return tipoEspecialidade; }
            set {  tipoEspecialidade = value; }
        }
        #endregion

        #region Outros Metodos

        #endregion

        #endregion
    }


}
