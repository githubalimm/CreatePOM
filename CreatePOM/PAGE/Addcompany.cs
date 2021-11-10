using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CreatePOM.PAGE
{
    class Addcompany : DriverHelper
    {

        IWebElement entercompany = Driver.FindElement(By.XPath("//input[@id='txtCompanyName']"));

        IWebElement searchcom = Driver.FindElement(By.XPath("//input[@id='ibtnSearchCompanies']"));
       
        IWebElement createcom = Driver.FindElement(By.XPath("//input[@id='ibtnAddCompany']"));

        public void entercompanys(string name)
        {
            entercompany.SendKeys(name);
            Thread.Sleep(2000);
        
        }
        public void clickc()
        {
            searchcom.Click();
            Thread.Sleep(5000);
           
        }
        public void clickN()
        {
            createcom.Click();
            Thread.Sleep(5000);

        }
    }
    
            
}
