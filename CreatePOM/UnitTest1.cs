using CreatePOM;
using CreatePOM.PAGE;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace Tests
{
    public class Tests 
    {
        public ChromeDriver Driver { get; private set; }

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }

        [Test]

        public void Logintest()
        {

            Driver.Navigate().GoToUrl("https://titanuat.regus.com/aspx/main/adminhome.aspx");
            Login log = new Login();
            log.entername("Q.A@iwgplc.com");
            log.click();
            log.enterpassord("cFZsDNvP9%rvTTu3");
            log.click1();

            ActionOperation on = new ActionOperation();
            on.action();


            Addcompany add = new Addcompany();
            add.entercompanys("RTA - TEST2");
            add.clickc();
            add.clickN();


            Newcompany newc = new Newcompany();
            newc.addframe();
            newc.enteraddresss("street 7d");
            newc.selectcodee();
            newc.enternumm("28547896584");
            newc.entercityy("torontoss");
            newc.zipcodee("MI-456");
            newc.selectcountryy();
            newc.enterstatee();
            newc.add();

            Addnewcontact addn = new Addnewcontact();
            addn.copyrefer();
            addn.addnewcon();

            MembershipNO mb = new MembershipNO();
            mb.entername();
            mb.selectgender();
            mb.entercityyy("torontoss");
            mb.enteraddresss("street 7d");
            mb.zipcodeee("MI-456");
            mb.selectcountryy();
            mb.enterstatee();
            mb.copycustomerr();

            mb.selectcodde();
           
            mb.enteremail();
            mb.copymembership();




        }


        
    }
}