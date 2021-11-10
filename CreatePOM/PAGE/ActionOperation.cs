using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CreatePOM.PAGE
{
    class ActionOperation : DriverHelper
    {
     
          
        public void action()
        {
            IWebElement headerimg = Driver.FindElement(By.XPath("//div[@class='PageHeader']//img[3]"));
            Actions action1 = new Actions(Driver);
            action1.MoveToElement(headerimg).Perform();
            Thread.Sleep(5000);

            //  FOR FRAME CODE //

            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iframe[@src='about:blank']")));

            Driver.FindElement(By.XPath("//td[normalize-space()='Client Search']")).Click();


            //  USE TO COME OUT FROM THE FRAME //

            Driver.SwitchTo().DefaultContent();
        }

    }
}
