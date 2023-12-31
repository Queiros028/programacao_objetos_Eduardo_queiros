using ObjetosNegocio;
using RegrasNegocio;
/**
 *  Testes das fun��es criadas
 */
namespace testes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            #region testes com dados invalidos
            [TestMethod]
            // testar inser��o de utentes com valores invalidos...
            void testeInsereUtenteInvalido()
            {
                int id = 1;
                Utente utenteInvalido = new Utente
                {
                    Idade = 2, //minimo idade = 5
                    Nome = " ", //nome nao pode ser nulo
                    Mail = "", //mail nao pode ser nulo
                };
                bool resultado = GereClinica.InsereUtenteValid(utenteInvalido, id);
                Assert.ThrowsException<Exception>(() => GereClinica.InsereUtenteValid(utenteInvalido, id));
                //Assert.IsTrue(resultado);
            }

            [TestMethod]
            void testeRemoverUtenteInvalido()
            {
                int id = 1;
                Utente utenteInvalido = new Utente
                {
                    Idade = 1,
                    Nome = " ",
                    Mail = " ",
                };
                bool resultado = GereClinica.InsereUtenteValid(utenteInvalido, id);
                Assert.ThrowsException<Exception>(() => GereClinica.InsereUtenteValid(utenteInvalido, id));

            }


            #endregion

            #region testes com dados validos
            [TestMethod]
            //testar inser��o de utente com valores validos
            void testeInsereUtenteValido()
            {
                int id = 1;
                Utente utente = new Utente
                {
                    Idade = 15,
                    Nome = "ze",
                    Mail = "ze@gmail.com",
                };
                bool resultado = RegrasNegocio.GereClinica.InsereUtenteValid(utente, id);
                Assert.IsTrue(resultado);
            }


            [TestMethod]
            void testeRemoverUtenteValido()
            {
                int id = 1;
                Utente utente = new Utente
                {
                    Idade = 15,
                    Nome = "ze",
                    Mail = "ze@gmail.com",
                };
                bool resultado = RegrasNegocio.GereClinica.removerU(utente, id);
                Assert.IsTrue(resultado);
            }


            #endregion

        }
    }
}