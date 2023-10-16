using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace WebsiteTests
{
    internal class Program
    {
        static void Main(string[] args)
        { }
        public class Tests
        {
            IWebDriver driver;

            public object ExpectedConditions { get; private set; }

            [Test]
            public void Jazik()
            {

                ChromeDriver chromeDriver = new ChromeDriver();

                IWebDriver driver = chromeDriver;
                driver.Navigate().GoToUrl("https://www.telekom.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"languages\"]/div[1]/div[3]")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"languages\"]/div[1]/div[2]")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"languages\"]/div[1]/div[1]")).Click();
                Thread.Sleep(2000);

                driver.Close();


            }

            [Test]
            public void Linkovi()
            {
                ChromeDriver chromeDriver = new ChromeDriver();

                IWebDriver driver = chromeDriver;
                driver.Navigate().GoToUrl("https://www.telekom.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.LinkText("Magenta 1")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.LinkText("Најбарана понуда")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.LinkText("Уреди")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.PartialLinkText("iPhone")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.PartialLinkText("Мобилни")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.LinkText("Припејд")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.PartialLinkText("Интернет")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.PartialLinkText("Телевизија")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.PartialLinkText("Корисничка")).Click();
                Thread.Sleep(2000);

                driver.Close();



            }

            [Test]
            public void SearchBar()
            {
                ChromeDriver chromeDriver = new ChromeDriver();

                IWebDriver driver = chromeDriver;
                driver.Navigate().GoToUrl("https://www.telekom.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"header\"]/div/div[3]/div/div/div[2]/div/a[1]/div[1]")).Click();
                Thread.Sleep(2000);


                driver.FindElement(By.Id("qr")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("qr")).SendKeys("Apple");
                driver.FindElement(By.Id("qr")).SendKeys(Keys.Enter);
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"header\"]/div/div[3]/div/div/div[2]/div/a[1]/div[1]")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("qr")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("qr")).SendKeys("Samsung");
                driver.FindElement(By.Id("qr")).SendKeys(Keys.Enter);
                Thread.Sleep(2000);

                driver.Close();





            }

            [Test]
            public void SocialMediaLinks()
            {
                ChromeDriver chromeDriver = new ChromeDriver();

                IWebDriver driver = chromeDriver;
                driver.Navigate().GoToUrl("https://www.telekom.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);

                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
                js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id=\"ns-bottom\"]/div/div[2]/div/div/div/div[3]/div/ul/li[1]/a")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//*[@id=\"ns-bottom\"]/div/div[2]/div/div/div/div[3]/div/ul/li[2]/a")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//*[@id=\"ns-bottom\"]/div/div[2]/div/div/div/div[3]/div/ul/li[3]/a")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//*[@id=\"ns-bottom\"]/div/div[2]/div/div/div/div[3]/div/ul/li[4]/a")).Click();
                Thread.Sleep(5000);
                driver.Close();
            }

            [Test]
            public void TermsOfServiceLink()
            {
                ChromeDriver chromeDriver = new ChromeDriver();

                IWebDriver driver = chromeDriver;
                driver.Navigate().GoToUrl("https://www.telekom.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);

                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
                js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id=\"ns-bottom\"]/div/div[4]/div/div/div[2]/ul/li[1]/a")).Click();

                driver.Close();
            }

            [Test]
            public void PrivacyPolicyLink()
            {
                ChromeDriver chromeDriver = new ChromeDriver();

                IWebDriver driver = chromeDriver;
                driver.Navigate().GoToUrl("https://www.telekom.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);

                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
                js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id=\"ns-bottom\"]/div/div[4]/div/div/div[2]/ul/li[2]/a")).Click();
                Thread.Sleep(2000);
                js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
                Thread.Sleep(2000);
                Assert.IsTrue(driver.FindElement(By.XPath("//*[@id=\"home\"]/ul/li[10]/a")).Text.Contains("АД"));
                driver.Close();
            }

            [Test]
            public void RegistrationLink()
            {
                ChromeDriver chromeDriver = new ChromeDriver();

                IWebDriver driver = chromeDriver;
                driver.Navigate().GoToUrl("https://www.telekom.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id=\"loginNameMove\"]/a")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[2]/div/div[2]/div/div/form/fieldset/div[3]/p/a")).Click();
                Thread.Sleep(2000);

                driver.Close();
            }


            [Test]
            public void AppLinks()
            {
                ChromeDriver chromeDriver = new ChromeDriver();

                IWebDriver driver = chromeDriver;
                driver.Navigate().GoToUrl("https://www.telekom.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);

                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
                js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id=\"ns-bottom\"]/div/div[2]/div/div/div/div[2]/div/div[2]/div/a[1]")).Click();
                Thread.Sleep(2000);
                driver.Navigate().Back();
                driver.FindElement(By.XPath("//*[@id=\"ns-bottom\"]/div/div[2]/div/div/div/div[2]/div/div[2]/div/a[2]")).Click();
                Thread.Sleep(2000);
                driver.Navigate().Back();
                driver.FindElement(By.XPath("//*[@id=\"ns-bottom\"]/div/div[2]/div/div/div/div[2]/div/div[2]/div/a[3]")).Click();
                Thread.Sleep(2000);
                driver.Navigate().Back();

                driver.Close();
            }

            [Test]
            public void TelekomVideo()
            {
                ChromeDriver chromeDriver = new ChromeDriver();

                IWebDriver driver = chromeDriver;
                driver.Navigate().GoToUrl("https://www.telekom.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"top-bar-left\"]/ul/li[3]")).Click();
                Thread.Sleep(4000);

                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript($"window.scrollTo(0, (document.body.scrollHeight * {0.50}));");
                Thread.Sleep(5000);

                driver.FindElement(By.PartialLinkText("кампања")).Click();
                Thread.Sleep(5000);
                js.ExecuteScript($"window.scrollTo(0, (document.body.scrollHeight * {0.30}));");
                Thread.Sleep(5000);
                IWebElement iframe = driver.FindElement(By.XPath("//iframe[@src='https://www.youtube.com/watch?v=IbLLmtWx1Y4']"));
                driver.SwitchTo().Frame(iframe);
                IWebElement playButton = driver.FindElement(By.XPath("//*[@id=\"movie_player\"]/div[4]/button"));
                playButton.Click();
                Thread.Sleep(7000);
                driver.FindElement(By.Id("body")).SendKeys("k");
                Thread.Sleep(2000);
                driver.Close();


            }

            [Test]
            public void Homepage()
            {
                ChromeDriver chromeDriver = new ChromeDriver();

                IWebDriver driver = chromeDriver;
                driver.Navigate().GoToUrl("https://www.telekom.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.PartialLinkText("Мобилни")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id=\"mainmenu\"]/ul/li[3]/ul/li[4]")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//*[@id=\"header\"]/div/div[1]/div[1]/a/img")).Click();
                Thread.Sleep(5000);

                driver.Close();


            }

            [Test]
            public void KupiSega()
            {
                ChromeDriver chromeDriver = new ChromeDriver();

                IWebDriver driver = chromeDriver;
                driver.Navigate().GoToUrl("https://www.telekom.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.LinkText("Уреди")).Click();
                Thread.Sleep(2000);


                driver.FindElement(By.XPath("//*[@id=\"mainmenu\"]/ul/li[2]/ul/li[4]/a")).Click();
                Thread.Sleep(5000);

                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript($"window.scrollTo(0, (document.body.scrollHeight * {0.10}));");
                Thread.Sleep(5000);

                driver.FindElement(By.XPath("//*[@id=\"t-phone-family\"]/div[2]/div/div[10]/div/div/a[1]")).Click();
                Thread.Sleep(5000);

                driver.Close();

            }

            [Test]
            public void AddToCart()
            {
                ChromeDriver chromeDriver = new ChromeDriver();


                IWebDriver driver = chromeDriver;
                driver.Navigate().GoToUrl("https://www.telekom.mk/mobile-device-details.nspx?deviceId=53050&promotion=0&name=T%20Phone%205G%202023%20128GB%20Dusty%20Grey&familijarenBudzet=2&color=dusty%20grey");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id=\"phone-details\"]/div[1]/div/div[2]/div[2]/div/div[1]/div/div[4]")).Click();
                Thread.Sleep(2000);

                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript($"window.scrollTo(0, (document.body.scrollHeight * {0.20}));");
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//*[@id=\"priceAffix\"]/div/div[4]/div/div/a")).Click();
                Thread.Sleep(5000);

                driver.Close();
            }

            [Test]
            public void LoadTime()
            {
                ChromeDriver chromeDriver = new ChromeDriver();
                IWebDriver driver = chromeDriver;
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.Navigate().GoToUrl("https://www.telekom.mk");

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                IWebElement elementToWaitFor = driver.FindElement(By.TagName("body"));

                stopwatch.Stop();

                long loadTimeMs = stopwatch.ElapsedMilliseconds;
                Assert.Less(loadTimeMs, 5000);

                driver.Close();

            }

            [Test]
            public void InfoInput()
            {
                ChromeDriver chromeDriver = new ChromeDriver();

                IWebDriver driver = chromeDriver;
                driver.Navigate().GoToUrl("https://www.telekom.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("loginNameMove")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.Name("UserName")).SendKeys("stefangacinovic@gmail.com");
                Thread.Sleep(2000);

                driver.FindElement(By.Name("Password")).SendKeys("Password");
                Thread.Sleep(5000);
                driver.Close();
            }

            [Test]
            public void Firefox()
            {
                FirefoxDriver firefoxDriver = new FirefoxDriver();

                IWebDriver driver = firefoxDriver;
                driver.Navigate().GoToUrl("https://www.telekom.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);

                driver.Close();
            }

            [Test]
            public void LoadTimeFirefox()
            {
                FirefoxDriver firefoxDriver = new FirefoxDriver();
                IWebDriver driver = firefoxDriver;
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.Navigate().GoToUrl("https://www.telekom.mk");

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                IWebElement elementToWaitFor = driver.FindElement(By.TagName("body"));

                stopwatch.Stop();

                long loadTimeMs = stopwatch.ElapsedMilliseconds;
                Assert.Less(loadTimeMs, 5000);

                driver.Close();

            }

            [Test]
            public void SearchBarFirefox()
            {
                FirefoxDriver firefoxDriver = new FirefoxDriver();

                IWebDriver driver = firefoxDriver;
                driver.Navigate().GoToUrl("https://www.telekom.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"header\"]/div/div[3]/div/div/div[2]/div/a[1]/div[1]")).Click();
                Thread.Sleep(2000);


                driver.FindElement(By.Id("qr")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("qr")).SendKeys("Apple");
                driver.FindElement(By.Id("qr")).SendKeys(Keys.Enter);
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"header\"]/div/div[3]/div/div/div[2]/div/a[1]/div[1]")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("qr")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("qr")).SendKeys("Samsung");
                driver.FindElement(By.Id("qr")).SendKeys(Keys.Enter);
                Thread.Sleep(2000);

                driver.Close();





            }

            [Test]
            public void Edge()
            {
                EdgeDriver edgeDriver = new EdgeDriver();

                IWebDriver driver = edgeDriver;
                driver.Navigate().GoToUrl("https://www.telekom.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);

                driver.Close();
            }

            [Test]
            public void LoadTimeEdge()
            {
                EdgeDriver edgeDriver = new EdgeDriver();
                IWebDriver driver = edgeDriver;
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.Navigate().GoToUrl("https://www.telekom.mk");

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                IWebElement elementToWaitFor = driver.FindElement(By.TagName("body"));

                stopwatch.Stop();

                long loadTimeMs = stopwatch.ElapsedMilliseconds;
                Assert.Less(loadTimeMs, 5000);

                driver.Close();

            }

            [Test]
            public void InfoInputEdge()
            {
                EdgeDriver edgeDriver = new EdgeDriver();

                IWebDriver driver = edgeDriver;
                driver.Navigate().GoToUrl("https://www.telekom.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("loginNameMove")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.Name("UserName")).SendKeys("stefangacinovic@gmail.com");
                Thread.Sleep(2000);

                driver.FindElement(By.Name("Password")).SendKeys("Password");
                Thread.Sleep(5000);
                driver.Close();
            }




            [Test]
            public void JazikNeptun()
            {

                ChromeDriver chromeDriver = new ChromeDriver();

                IWebDriver driver = chromeDriver;
                driver.Navigate().GoToUrl("https://www.neptun.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"ctl00_ctl00_ctl00_cmscontent_CmsMain_ctl02_ctl01_divContent\"]/div/div/div/div/button/span")).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"ctl00_ctl00_ctl00_cmscontent_ctl00_btnsq-AL\"]")).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.XPath("//*[@id=\"ctl00_ctl00_ctl00_cmscontent_ctl00_btnmk-MK\"]")).Click();
                Thread.Sleep(3000);


                driver.Close();


            }

            [Test]
            public void LinkoviNeptun()
            {
                ChromeDriver chromeDriver = new ChromeDriver();

                IWebDriver driver = chromeDriver;
                driver.Navigate().GoToUrl("https://www.neptun.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"ctl00_ctl00_ctl00_cmscontent_CmsMain_ctl02_ctl01_divContent\"]/div/div/div/div/button/span")).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.LinkText("ПРОИЗВОДИ")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.LinkText("ПРОМОЦИИ")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.LinkText("УСЛУГИ")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.LinkText("ВЕСТИ")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.LinkText("haPPy")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.LinkText("OUTLET")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.LinkText("GREEN")).Click();
                Thread.Sleep(2000);


                driver.Close();

            }

            [Test]
            public void LoginNeptun()
            {
                ChromeDriver chromeDriver = new ChromeDriver();

                IWebDriver driver = chromeDriver;
                driver.Navigate().GoToUrl("https://www.neptun.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"ctl00_ctl00_ctl00_cmscontent_CmsMain_ctl02_ctl01_divContent\"]/div/div/div/div/button/span")).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"affix5\"]/div/div[1]/div[1]/a")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"ctl00_ctl00_ctl00_cmscontent_CmsMain_ctl00_ctl00_authapp\"]/login/div/div/div/div[1]/div[1]/input")).SendKeys("stefangacinovic@gmail.com");
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"ctl00_ctl00_ctl00_cmscontent_CmsMain_ctl00_ctl00_authapp\"]/login/div/div/div/div[1]/div[2]/input")).SendKeys("Password.123");
                Thread.Sleep(2000);

                driver.Close();
            }

            [Test]
            public void SearchBarNeptun()
            {
                ChromeDriver chromeDriver = new ChromeDriver();

                IWebDriver driver = chromeDriver;
                driver.Navigate().GoToUrl("https://www.neptun.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"ctl00_ctl00_ctl00_cmscontent_CmsMain_ctl02_ctl01_divContent\"]/div/div/div/div/button/span")).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"searchautocomplete-app\"]/div/div/div/input[2]")).SendKeys("Apple");
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id=\"searchautocomplete-app\"]/div/div/div/input[2]")).SendKeys(Keys.Enter);


                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"searchautocomplete-app\"]/div/div/div/input[2]")).SendKeys("Samsung");
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id=\"searchautocomplete-app\"]/div/div/div/input[2]")).SendKeys(Keys.Enter);
                Thread.Sleep(2000);
                driver.Close();
            }

            [Test]
            public void AddToCartNeptun()
            {
                ChromeDriver chromeDriver = new ChromeDriver();


                IWebDriver driver = chromeDriver;
                driver.Navigate().GoToUrl("https://www.neptun.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"ctl00_ctl00_ctl00_cmscontent_CmsMain_ctl02_ctl01_divContent\"]/div/div/div/div/button/span")).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id=\"searchautocomplete-app\"]/div/div/div/input[2]")).SendKeys("Samsung");
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id=\"searchautocomplete-app\"]/div/div/div/input[2]")).SendKeys(Keys.Enter);
                Thread.Sleep(2000);
                driver.FindElement(By.PartialLinkText("QN100")).Click();
                Thread.Sleep(5000);

                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript($"window.scrollTo(0, (document.body.scrollHeight * {0.10}));");
                Thread.Sleep(5000);

                driver.FindElement(By.XPath("//*[@id=\"mainContainer\"]/div[2]/div[2]/div[3]/div[6]/div[2]/div[2]/div[1]/button")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"ctl00_ctl00_ctl00_cmscontent_WebShopMiniCart_app\"]/a")).Click();
                Thread.Sleep(3000);
                driver.Close();
            }

            [Test]
            public void LoadTimeNeptun()
            {
                ChromeDriver chromeDriver = new ChromeDriver();
                IWebDriver driver = chromeDriver;
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.Navigate().GoToUrl("https://www.neptun.mk");

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                IWebElement elementToWaitFor = driver.FindElement(By.TagName("body"));

                stopwatch.Stop();

                long loadTimeMs = stopwatch.ElapsedMilliseconds;
                Assert.Less(loadTimeMs, 5000);

                driver.Close();

            }


            [Test]
            public void PonudiNeptun()
            {
                ChromeDriver chromeDriver = new ChromeDriver();


                IWebDriver driver = chromeDriver;
                driver.Navigate().GoToUrl("https://www.neptun.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"ctl00_ctl00_ctl00_cmscontent_CmsMain_ctl02_ctl01_divContent\"]/div/div/div/div/button/span")).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);

                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript($"window.scrollTo(0, (document.body.scrollHeight * {0.20}));");
                Thread.Sleep(5000);

                driver.FindElement(By.XPath("//*[@id=\"ctl00_ctl00_ctl00_cmscontent_CmsMain_ctl02_ctl00_app\"]/div/div/div/div[2]/div/div/div[1]/div/div[1]/div/div[2]/div/div/a[1]/span")).Click();
                Thread.Sleep(2000);



                driver.FindElement(By.XPath("//*[@id=\"affix2\"]/div/div[2]/ul/li[5]/a")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id=\"affix2\"]/div/div[2]/ul/li[8]/a")).Click();
                Thread.Sleep(2000);

                driver.Close();
            }

            [Test]
            public void PonudiNeptunAF()
            {
                ChromeDriver chromeDriver = new ChromeDriver();


                IWebDriver driver = chromeDriver;
                driver.Navigate().GoToUrl("https://www.neptun.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"ctl00_ctl00_ctl00_cmscontent_CmsMain_ctl02_ctl01_divContent\"]/div/div/div/div/button/span")).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);

                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript($"window.scrollTo(0, (document.body.scrollHeight * {0.20}));");
                Thread.Sleep(5000);

                driver.FindElement(By.XPath("//*[@id=\"ctl00_ctl00_ctl00_cmscontent_CmsMain_ctl02_ctl00_app\"]/div/div/div/div[2]/div/div/div[1]/div/div[1]/div/div[2]/div/div/a[1]/span")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@id=\"mainContainer\"]/div/div[1]/aside/div[1]/div/div[2]/div/div/ul/li[1]/div/a")).Click();
                Thread.Sleep(2000);

                js.ExecuteScript($"window.scrollTo(0, (document.body.scrollHeight * {0.20}));");
                Thread.Sleep(5000);

                driver.Close();
            }

                [Test]
                public void EdgeNeptun()
                {
                    EdgeDriver edgeDriver = new EdgeDriver();

                    IWebDriver driver = edgeDriver;
                    driver.Navigate().GoToUrl("https://www.neptun.mk");
                    driver.Manage().Window.Maximize();
                    Thread.Sleep(2000);
                    driver.FindElement(By.XPath("//*[@id=\"ctl00_ctl00_ctl00_cmscontent_CmsMain_ctl02_ctl01_divContent\"]/div/div/div/div/button/span")).Click();
                    Thread.Sleep(3000);
                    driver.FindElement(By.Id("all-cookies-btn")).Click();
                    Thread.Sleep(2000);

                    driver.Close();
                }

            [Test]
            public void FirefoxNeptun()
            {
                FirefoxDriver firefoxDriver = new FirefoxDriver();

                IWebDriver driver = firefoxDriver;
                driver.Navigate().GoToUrl("https://www.neptun.mk");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id=\"ctl00_ctl00_ctl00_cmscontent_CmsMain_ctl02_ctl01_divContent\"]/div/div/div/div/button/span")).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.Id("all-cookies-btn")).Click();
                Thread.Sleep(2000);

                driver.Close();
            }





























        }
            }
        }
    






