using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CreatePOM.PAGE
{
    class MembershipNO : DriverHelper
    {
        IWebElement enterfirstnam = Driver.FindElement(By.XPath("//input[@id='bfcMain_txtFirstName']"));
        IWebElement entersecondnam = Driver.FindElement(By.XPath("//input[@id='bfcMain_txtLastName']"));
        IWebElement gendermale = Driver.FindElement(By.XPath("//input[@id='bfcMain_radGenderMale']"));
        IWebElement entercity1 = Driver.FindElement(By.XPath("//input[@id='bfcMain_ucContactAddress_txtAddress1']"));
        IWebElement enteraddress1 = Driver.FindElement(By.XPath("//input[@id='bfcMain_ucContactAddress_txtCity']"));
        IWebElement zipcode1 = Driver.FindElement(By.XPath("//input[@id='bfcMain_ucContactAddress_txtZip']"));
        IWebElement selectcountry1 = Driver.FindElement(By.XPath("//select[@id='bfcMain_ucContactAddress_ddlCountry']"));
        IWebElement state = Driver.FindElement(By.XPath("//select[@id='bfcMain_ucContactAddress_ddlState']"));
        IWebElement copycustomer = Driver.FindElement(By.XPath("//a[normalize-space()='Copy from Company Details']"));

        IWebElement selectcode1 = Driver.FindElement(By.XPath("//select[@id='bfcMain_ddlCountryDialCodes']"));
       
            IWebElement enternum1 = Driver.FindElement(By.XPath("//input[@id='bfcMain_txtPhone']"));
      
            
            IWebElement email = Driver.FindElement(By.XPath("//input[@id='bfcMain_txtEmail']"));
        

       
            IWebElement save = Driver.FindElement(By.XPath("//input[@id='bfcMain_iBtnUpdate']"));
        
            IWebElement copymembership1 = Driver.FindElement(By.XPath("//span[@id='bfcMain_lblMembershipNumber']"));
       






        public void entername()
        {


            Random ran = new Random();
            String b = "abcdefghijklmnopqrstuvwxyz";
            int length = 3;
            String random = "";
            for (int i = 0; i < length; i++)
            {
                int a = ran.Next(26);
                random = random + b.ElementAt(a);
            }
            enterfirstnam.SendKeys("test" + random);
            Thread.Sleep(5000);

            entersecondnam.SendKeys("test" + random);
            Thread.Sleep(2000);
        }

        public void selectgender()
        {
            gendermale.Click();

            Thread.Sleep(2000);
        }

       


        public void entercityyy(string name)
        {
            entercity1.SendKeys(name);
            Thread.Sleep(5000);

        }
        public void enteraddresss(string name)
        {
            enteraddress1.SendKeys(name);
            Thread.Sleep(5000);

        }
        public void zipcodeee(string name)
        {
            zipcode1.SendKeys(name);
            Thread.Sleep(7000);

        }
        public void selectcountryy()
        {
            SelectElement sel = new SelectElement(selectcountry1);
            sel.SelectByValue("611");
            Thread.Sleep(11000);

        }


        public void enterstatee()
        {

            SelectElement stt = new SelectElement(state);
            stt.SelectByValue("1147");
            Thread.Sleep(5000);

        }
        public void copycustomerr()
        {

            copycustomer.Click();
            Thread.Sleep(5000);

        }


/// <summary>
/// </summary>
        public void selectcodde()
        {
            SelectElement sc1 = new SelectElement(selectcode1);
            sc1.SelectByValue("611");
            Thread.Sleep(2000);

        }
       
        public void enteremail()
        {
            Random r = new Random();

            string em = string.Format($"rta{r.Next(100)}@zetmail.com");

            email.SendKeys(em);
            Thread.Sleep(2000);

        }
        public void savedata()
        {

            save.Click();
            Thread.Sleep(5000);

        }

      

        public void copymembership()
        {
            string ship = copymembership1.Text;
            Console.WriteLine("membership reference is " + ship);


            Driver.SwitchTo().DefaultContent();

        }




    }

}
