/*
 *"Parâmetros" de pessoa(pode ser Utente, Funcionario, Medico)
 *Autor: Eduardo Queirós, nº 23005
 *
 */
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
        protected int idade;

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
        /// <summary>
        /// Construtor de pessoa com parâmetros default
        /// </summary>
        public Pessoa()
        {
            nome = "";
            descricao = tipo;
            codGlobal = cod;
            cod++;
            idade = 20;
            descricao = DescricaoPessoa.UTENTE;
            //descricao = DescricaoPessoa.MEDICO;
            //descricao = DescricaoPessoa.FUNCIONARIO;            
        }
        /// <summary>
        /// Construtor Pessoa
        /// </summary>
        /// <param name="Nome"></param>
        /// <param name="descricaoP"></param>
        /// <param name="codGlob"></param>
        /// <param name="Idade"></param>
        public Pessoa(string Nome, DescricaoPessoa descricaoP, int codGlob, int Idade)
        {
            nome = Nome;
            descricao = descricaoP;
            codGlobal = codGlob;
            idade = Idade;
        }

        #endregion

        #region Propriedades
        /// <summary>
        /// Propriedade para o nome da pessoa
        /// </summary>
        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        /// <summary>
        /// Propriedade para o tipo de pessoa que é
        /// </summary>
        public DescricaoPessoa tipo
        {
            get { return descricao; }
            set { descricao = value; }
        }

      //ACHO QUE FALTA UMA PARA O CODGLOBAL!!!!!!


      /// <summary>
      /// Propriedade para a idade da pessoa
      /// </summary>
        public int Idade
        {
            set { idade = value; }
            get { return idade; }
        }

        #endregion

        #region override
        /// <summary>
        /// Formato dos dados da pessoa ao ser "chamado"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Ficha da Pessoa-> Nome: {0}; Funcao: {1} ; codigo {2}\n; idade{3}\n", nome, descricao, codGlobal, idade);
        }

        #endregion


        #region Outros Metodos
        /// <summary>
        /// Comparar se dois objetos pessoa são iguais
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Calcula o código Hash
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Inicializar o numero de cartao de saude a 0
        /// </summary>
        static Utente()
        {
            numCartaoSaude = 0;
        }
        /// <summary>
        /// Construtor para parametros default
        /// </summary>
        public Utente()
        {
            Nome = "Antonio";
            codGlobal = 10;
            Idade = 17;
            mail = " ";
            numTelef = 987654321;
            numCartaoSaude++;
        }
        /// <summary>
        /// Construtor de Utente
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="codUtente"></param>
        /// <param name="Mail"></param>
        /// <param name="NumTelefUtente"></param>
        /// <param name="idadeUtente"></param>
        public Utente(string nome, int codUtente, string Mail, int NumTelefUtente, int idadeUtente)
        {
            Nome = nome;
            codGlobal = codUtente;
            Idade = idadeUtente;
            mail = Mail;
            numTelef = NumTelefUtente;
            numCartaoSaude++;
        }

        #endregion

        #region Propriedades
        /*
         * nota: nao vou fazer nd para o num de cartao de saude porque quero que n se mexa nisso e que seja o programa a "atibuir" pois tenho o numCartaoSaude++;
         */

        /// <summary>
        /// Propriedade para o email do utente
        /// </summary>
        public string Mail
        {
            set { mail = value; }
            get { return mail; }
        }

        /// <summary>
        /// Propriedade para o num de telefone do utente
        /// </summary>
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
        /// Construtor parametros default para funcionário
        /// </summary>
        public Funcionario()
        {
            Nome = "Joaquim ";
            codGlobal = 20;
            idade = 23;
            //descricao = DescricaoPessoa.FUNCIONARIO; -> penso que n faz sentido por isso retirei
            cargo = CargoFuncionario.ASSISTENTE;
            numTelef = 912345678;
            horario = 2;
            salario = 900;
        }
        /// <summary>
        /// Construtor para funcionário
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="codigoFunc"></param>
        /// <param name="CargoFunc"></param>
        /// <param name="NumTeleFuncionario"></param>
        /// <param name="HorarioFunc"></param>
        /// <param name="SalarioFunc"></param>
        /// <param name="idadeFunc"></param>
        public Funcionario(string nome, int codigoFunc,CargoFuncionario CargoFunc, int NumTeleFuncionario, int HorarioFunc, int SalarioFunc, int idadeFunc)
        {
            Nome = nome;
            codGlobal = codigoFunc;
            Idade = idadeFunc;
            cargo = CargoFunc;
            numTelef = NumTeleFuncionario;
            horario = HorarioFunc;
            salario = SalarioFunc;
        }

        #endregion

        #region Propriedades
        /// <summary>
        /// Propriedade para o cargo do funcionario
        /// </summary>
        public CargoFuncionario cargoFunc
        {
            get { return cargoFunc; }
            set { cargoFunc = value; }
        }
        /// <summary>
        /// Propriedade para o numero de telefone do funcionario
        /// </summary>
        public int NumTelef
        {
            get { return numTelef; } 
            set { numTelef = value; }
        }
        /// <summary>
        /// Propriedade para ver qual o horario de trabalho do funcionario
        /// </summary>
        public int Horario
        {
            get { return horario; }
            set { horario = value; }
        }
        /// <summary>
        /// Propriedade para o salário do funcionario
        /// </summary>
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
        /// Construtor com parâmetros default
        /// </summary>
        public Medico()
        {
            Nome = "Maria";
            codGlobal = 30;
            idade = 27;
            salario = 1000;
            horarioTrabalho = 5;
            tipoEspecialidade = Especialidade.ORTODONTIA;
        }
        
        /// <summary>
        /// Construtor para Medico
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="codMedico"></param>
        /// <param name="Salario"></param>
        /// <param name="Horario"></param>
        /// <param name="TipoEsp"></param>
        /// <param name="idadeMedico"></param>
        public Medico(string nome, int codMedico, int Salario,int Horario,Especialidade TipoEsp, int idadeMedico)
        {
            Nome = nome;
            codGlobal = codMedico;
            Idade = idadeMedico;
            salario = Salario;
            horarioTrabalho = Horario;
            tipoEspecialidade = TipoEsp;
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Propriedade para o salário do medico
        /// </summary>
        public int Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        /// <summary>
        /// Propriedade para verificar o horario de trabalho do medico
        /// </summary>
        public int HorarioTrabalho
        {
            get { return horarioTrabalho; }
            set { horarioTrabalho = value; }
        }
        /// <summary>
        /// Propriedade para a especialidade do medico
        /// </summary>
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
