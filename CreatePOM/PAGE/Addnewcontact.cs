using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CreatePOM.PAGE
{
    class Addnewcontact : DriverHelper
    {
        IWebElement copymembership = Driver.FindElement(By.XPath("//span[@id='bfcMain_lblCompanyRef']"));
        IWebElement addnewcontact = Driver.FindElement(By.XPath("//a[normalize-space()='Add New Contact']"));
        

        public void copyrefer()
        {
            string text = copymembership.Text;
            Console.WriteLine("reference is " + text);
            Thread.Sleep(5000);
        }

        public void addnewcon()
        {
            addnewcontact.Click();
            Thread.Sleep(5000);

        }
    }
}
