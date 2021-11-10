using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreatePOM.PAGE
{
    class Login : DriverHelper
    {
        IWebElement search = Driver.FindElement(By.XPath("//*[@id='i0116']"));

        IWebElement enterid = Driver.FindElement(By.XPath("//*[@id='idSIButton9']"));

        IWebElement enterpass = Driver.FindElement(By.XPath("//*[@id='i0118']"));

        IWebElement okbutton = Driver.FindElement(By.XPath("//*[@id='idSIButton9']"));


        public void entername(string name)
        {
            search.SendKeys(name);
           

        }
        public void enterpassord(string password)
        {
             enterpass.SendKeys(password);

        } 
        public void click()
        {
            enterid.Click();
        }
        public void click1()
        {
            okbutton.Click();

        }

    }


}
