using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace cadastroLogin
{
    [Binding]
    public class AutenticacaoNoSistemaSteps
    {
        private IWebDriver driver = new ChromeDriver();

        [Given(@"que estou na página de autenticacao")]
        public void GivenQueEstouNaPaginaDeAutenticacao()
        {
            driver.Navigate().GoToUrl("http://192.168.207.157/");
        }
        
        [When(@"eu preencho o campo CPF com o valor (.*)")]
        public void WhenEuPreenchoOCampoCPFComOValor(string cpf)
        {
            IWebElement cpfTxt = driver.FindElement(By.Id("CPF"));
            cpfTxt.SendKeys(cpf);
        }
        
        [When(@"preencha o campo Senha com o valor (.*)")]
        public void WhenPreenchaOCampoSenhaComOValor(string senha)
        {
            IWebElement senhaTxt = driver.FindElement(By.Id("Senha"));
            senhaTxt.SendKeys(senha);
        }
        
        [When(@"clico no botão Entrar")]
        public void WhenClicoNoBotaoEntrar()
        {
            driver.FindElement(By.XPath("//*[@value='Entrar']")).Click();
        }
        
        [Then(@"vejo na tela (.*)")]
        public void ThenVejoNaTela(string mensagem)
        {
            bool achouTexto = driver.PageSource.Contains(mensagem);
            if (!achouTexto)
            {
                Mensagens.TestPostMessage("Erro encontrado: \n" +  //colocar a classe
                    "CLASSE: AutenticacaoNoSistemaSteps\n" +
                    "MÉTODO: EntaoVejoNaTela.\n" +
                    "DESCRIÇÃO: Mensagem não exibida na tela: '" + mensagem + "'");
                throw new Exception("Erro encontrado: \n" +
                    "CLASSE: AutenticacaoNoSistemaSteps\n" +
                    "MÉTODO: EntaoVejoNaTela.\n" +
                    "DESCRIÇÃO: Mensagem não exibida na tela: '" + mensagem + "'");

            }
        }
    }
}
