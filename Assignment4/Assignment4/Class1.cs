﻿// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class InsuranceQuoteSuiteTest
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }
    [Test]
    public void InsuranceQuote01_InputValidAge24Experience3Accidents0_OutputEligibleInsuranceNoDiscount()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/testing/prog8170a04/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1552, 880);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Keval");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("383 Albert Street");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("email")).SendKeys("kpatel9797@conestogac.on.ca");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("24");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("0");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$5500"));
        }
    }
    [Test]
    public void InsuranceQuote02_InputValidAge25Experience3Accidents4_OutputInsuranceDeniedTooManyAccidents()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/testing/prog8170a04/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(881, 802);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Keval");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("383 Albert Street");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("email")).SendKeys("keval@gmail.com");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("4");
        driver.FindElement(By.Id("btnSubmit")).Click();
        driver.FindElement(By.Id("finalQuote")).Click();

        //Assert
        driver.FindElement(By.Id("finalQuote")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
        }
    }
    [Test]
    public void InsuranceQuote03_InputValidAge35Experience9Accidents2_OutputEligibleInsuranceWithDiscount()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/testing/prog8170a04/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(881, 802);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Keval");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("383 Albert Street");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("email")).SendKeys("keval@gmail.com");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).SendKeys("9");
        driver.FindElement(By.Id("accidents")).SendKeys("2");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$3905"));
        }
    }
    [Test]
    public void InsuranceQuote04_InputInvalidPhoneNumber_OutputErrorInvalidPhone()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/testing/prog8170a04/");
        driver.Manage().Window.Size = new System.Drawing.Size(881, 802);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Keval");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("383 Albert Street");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("phone")).SendKeys("1111111111");
        driver.FindElement(By.Id("email")).SendKeys("keval@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("27");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("0");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("phone-error")).Text, Is.EqualTo("Phone Number must follow the patterns 111-111-1111 or (111)111-1111"));
    }
    [Test]
    public void InsuranceQuote05_InputInvalidEmailAddress_OutputErrorInvalidEmail()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/testing/prog8170a04/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(881, 802);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Keval");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("383 Albert Street");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("email")).SendKeys("keval@gmail.com");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("keval@");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("28");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("0");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("email-error")).Text, Is.EqualTo("Must be a valid email address"));
    }
    [Test]
    public void InsuranceQuote06_InputInvalidPostalCode_OutputErrorInvalidPostalCode()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/testing/prog8170a04/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(881, 802);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Keval");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("383 Albert Street");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("phone")).SendKeys("1111111111");
        driver.FindElement(By.Id("email")).SendKeys("keval@gmail.com");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N23");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).SendKeys("15");
        driver.FindElement(By.Id("accidents")).SendKeys("1");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        driver.FindElement(By.Id("postalCode-error")).Click();
        {
            var element = driver.FindElement(By.Id("postalCode-error"));
            Actions builder = new Actions(driver);
            builder.DoubleClick(element).Perform();
        }
        Assert.That(driver.FindElement(By.Id("postalCode-error")).Text, Is.EqualTo("Postal Code must follow the pattern A1A 1A1"));
    }
    [Test]
    public void InsuranceQuote07_InputOmittedAge_OutputErrorAgeRequired()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/testing/prog8170a04/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(881, 802);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Keval");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("383 Albert Street");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("email")).SendKeys("keval@gmail.com");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("5");
        driver.FindElement(By.Id("accidents")).SendKeys("0");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Age (>=16) is required"));
    }
    [Test]
    public void insuranceQuote08InputOmittedAccidentsOutputErrorAccidentsRequired()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/testing/prog8170a04/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(881, 802);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Keval");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("383 Albert Street");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("email")).SendKeys("keval@gmail.com");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("8");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("accidents-error")).Text, Is.EqualTo("Number of accidents is required"));
    }
    [Test]
    public void InsuranceQuote09_InputOmittedExperience_OutputErrorExperienceRequired()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/testing/prog8170a04/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(881, 802);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Keval");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("383 Albert Street");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("email")).SendKeys("keval@gmail.com");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("experience-error")).Text, Is.EqualTo("Years of experience is required"));
    }
    [Test]
    public void InsuranceQuote10_InputInvalidAge15Experience0Accidents0_OutputErrorInvalidAge()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/testing/prog8170a04/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(881, 802);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Keval");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("383 Albert Street");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("email")).SendKeys("keval@gmail.com");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("15");
        driver.FindElement(By.Id("experience")).SendKeys("0");
        driver.FindElement(By.Id("accidents")).SendKeys("0");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Please enter a value greater than or equal to 16."));
    }
    [Test]
    public void InsuranceQuote11_InputValidAge50Experience35Accidents1_OutputNoInsuranceDriverAgeExperienceNotCorrect()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/testing/prog8170a04/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(885, 806);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Keval");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("383 Albert Street");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("email")).SendKeys("keval@gmail.com");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("50");
        driver.FindElement(By.Id("experience")).SendKeys("35");
        driver.FindElement(By.Id("accidents")).SendKeys("1");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("No Insurance for you!! Driver Age / Experience Not Correct"));
        }
    }
    [Test]
    public void InsuranceQuote12_InputValidAge50Experience34Accidents1_OutputNoInsuranceDriverAgeExperienceNotCorrect()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/testing/prog8170a04/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(881, 802);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Keval");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("383 Albert Street");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("email")).SendKeys("keval@gmail.com");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("40");
        driver.FindElement(By.Id("experience")).SendKeys("34");
        driver.FindElement(By.Id("accidents")).SendKeys("1");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("No Insurance for you!! Driver Age / Experience Not Correct"));
        }
    }
    [Test]
    public void InsuranceQuote13_InputValidAge40Experience15Accidents3_OutputInsuranceDeniedTooManyAccidents()
    {
        //Arange
        driver.Navigate().GoToUrl("http://localhost/testing/prog8170a04/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(881, 802);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Keval");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("383 Albert Street");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("email")).SendKeys("keval@gmail.com");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("40");
        driver.FindElement(By.Id("experience")).SendKeys("15");
        driver.FindElement(By.Id("accidents")).SendKeys("3");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
        }
    }
    [Test]
    public void InsuranceQuote14_InputOmittedPostalCode_OutputErrorPostalCodeRequired()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/testing/prog8170a04/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(882, 804);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.CssSelector(".card:nth-child(1) > div:nth-child(2)")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Keval");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("383 Albert Street");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("phone")).SendKeys("1111111111");
        driver.FindElement(By.Id("email")).SendKeys("keval@gmail.com");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("111-111-1111");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("30");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("2");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("1");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("postalCode-error")).Text, Is.EqualTo("Postal Code is required"));
    }
    [Test]
    public void InsuranceQuote15_InputOmittedPhoneNumber_OutputErrorPhoneNumberRequired()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/testing/prog8170a04/index.html");
        driver.Manage().Window.Size = new System.Drawing.Size(883, 805);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Keval");
        driver.FindElement(By.Id("lastName")).SendKeys("Patel");
        driver.FindElement(By.Id("address")).SendKeys("383 Albert Street");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("email")).SendKeys("keval@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("30");
        driver.FindElement(By.Id("experience")).SendKeys("10");
        driver.FindElement(By.Id("accidents")).SendKeys("1");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("phone-error")).Text, Is.EqualTo("Phone Number is required"));
    }
}
