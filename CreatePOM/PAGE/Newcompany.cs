using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CreatePOM.PAGE
{
    class Newcompany : DriverHelper
    {
        string homecenter = "1243";
       

        public void addframe()
        {

            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iframe[@id='ifEdit']")));


            IWebElement newnamecom = Driver.FindElement(By.XPath("//input[@id='bfcMain_txtCompanyName']"));
            Random r = new Random();

            string RTATEST = string.Format($"RTA-TEST{r.Next(1000)}");

            newnamecom.SendKeys(RTATEST);

            Thread.Sleep(5000);
            if (homecenter == "1243")
            {

                IWebElement selecthome = Driver.FindElement(By.XPath("//select[@id='bfcMain_ddlCentre']"));
                SelectElement os = new SelectElement(selecthome);
                os.SelectByValue(homecenter);
                Thread.Sleep(5000);
                IWebElement customertype = Driver.FindElement(By.XPath("//select[@id='bfcMain_ddlCustomerType']"));
                SelectElement cp = new SelectElement(customertype);
                cp.SelectByValue("100");
                Thread.Sleep(5000);
                IWebElement selectprice = Driver.FindElement(By.XPath("//select[@id='bfcMain_ddlClassification']"));
                SelectElement sp = new SelectElement(selectprice);
                sp.SelectByValue("199");
                Thread.Sleep(5000);
            }
            else
            {
                IWebElement selecthome = Driver.FindElement(By.XPath("//select[@id='bfcMain_ddlCentre']"));
                SelectElement os = new SelectElement(selecthome);
                os.SelectByValue(homecenter);
                Thread.Sleep(5000);
            }
        }

        IWebElement enteraddress = Driver.FindElement(By.XPath("//input[@id='bfcMain_ucCompanyAddress_txtAddress1']"));
        IWebElement selectcode = Driver.FindElement(By.XPath("//select[@id='bfcMain_ddlCountryDialCodes']"));
        IWebElement enternum = Driver.FindElement(By.XPath("//input[@id='bfcMain_txtPhone']"));
        IWebElement entercity = Driver.FindElement(By.XPath("//input[@id='bfcMain_ucCompanyAddress_txtCity']"));
        IWebElement zipcode = Driver.FindElement(By.XPath("//input[@id='bfcMain_ucCompanyAddress_txtZip']"));
        IWebElement selectcountry = Driver.FindElement(By.XPath("//select[@id='bfcMain_ucCompanyAddress_ddlCountry']"));
        IWebElement enterstate = Driver.FindElement(By.XPath("//select[@id='bfcMain_ucCompanyAddress_ddlState']"));
        IWebElement savebutton = Driver.FindElement(By.XPath("//input[@id='bfcMain_iBtnUpdate']"));
        

        public void enteraddresss(string name)
        {
            enteraddress.SendKeys(name);
            Thread.Sleep(5000);

        }

        public void selectcodee()
        {
            SelectElement sc = new SelectElement(selectcode);
            sc.SelectByValue("611");

        }

        public void enternumm(string name)
        {
            enternum.SendKeys(name);
            Thread.Sleep(5000);

        }

        public void entercityy(string name)
        {
            entercity.SendKeys(name);
            Thread.Sleep(5000);

        }
        public void zipcodee(string name)
        {
            zipcode.SendKeys(name);
            Thread.Sleep(7000);

        }
        public void selectcountryy()
        {
            SelectElement sel = new SelectElement(selectcountry);
            sel.SelectByValue("611");
            Thread.Sleep(11000);

        }


        public void enterstatee()
        {
            
            SelectElement stt = new SelectElement(enterstate);
            stt.SelectByValue("1147");
            Thread.Sleep(5000);

        }
        public void add()
        {

            savebutton.Click();
            Thread.Sleep(5000);
        }

    }

}
