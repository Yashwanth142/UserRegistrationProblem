using UserRegistration;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Collections.Generic;
using System.Xml.Linq;
using System;

namespace RegexTestCase
{
    [TestMethod]
        public void UseCase1()
        {
            try
            {
                string name = "Yashwanthcs";
                string expected = "First Name is valid";
                demo program = new demo();
                string actual = program.validname(name);
               
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex)
            {
                Assert.AreEqual("invalid first name", ex.Message);
            }
        }

        [TestMethod]
        public void UseCase2()
        {
            try
            {
                string lastname = "YashwanSs";
                string expected = "last Name is valid";
                demo program = new demo();
                string actual = program.validlname(lastname);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex)
            {
                Assert.AreEqual("invalid last name", ex.Message);
            }
        }

        [TestMethod]
        public void UseCase3()
        {
            try
            {
                string[] emails = new string[3] { "abc.xyz@bl.co.in", "a123@bl.co.in", "fhjjm33@bl.co" };

                for (int i = 0; i < 3; i++)
                {

                    string expected = "mail is valid";
                    demo program = new demo();
                    string actual = program.validmail(emails[i]);
                    Assert.AreEqual(expected, actual);
                }
            }
            catch (InvalidException ex)
            {
                Assert.AreEqual("invalid mail", ex.Message);
            }

        }

        [TestMethod]
        public void UseCase4()
        {
            try
            {
                string mb = "91 7003007008";
                string expected = "mobile is valid";
                demo program = new demo();
                string actual = program.validmobile(mb);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex)
            {
                Assert.AreEqual("invalid mobile number", ex.Message);
            }
        }
        [TestMethod]
        public void UseCase5()
        {
            try
            {
                string password = "Oslissadaz";
                string expected = "password is valid";
                demo program = new demo();
                string actual = program.validpwd1(password);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex)
            {
                Assert.AreEqual("invalid password", ex.Message);
            }

        }

        [TestMethod]
        public void UseCase6()
        {
            try
            {
                string password = "Yshwanthh";
                string expected = "password is valid";
                demo program = new demo();
                string actual = program.validpwd2(password);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex)
            {
                Assert.AreEqual("invalid password", ex.Message);
            }
        }

        [TestMethod]
        public void UseCase7()
        {
            try
            {
                string password = "Yashwanth9";
                string expected = "password is valid";
                demo program = new demo();
                string actual = program.validpwd3(password);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex)
            {
                Assert.AreEqual("invalid password", ex.Message);
            }
        }

        [TestMethod]
        public void UseCase8()
        {
            try
            {
                string password = "Yashwanth$9";
                string expected = "password is valid";
                demo program = new demo();
                string actual = program.validpwd(password);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex)
            {
                Assert.AreEqual("invalid password", ex.Message);
            }
        }

        [TestMethod]
        public void UseCase9()
        {
            try
            {
                string email1 = "abc.xyz@gmail.com";
                string expected = "mail is valid";
                demo program = new demo();
                string actual = program.validmail(email1);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex)
            {
                Assert.AreEqual("invalid password", ex.Message);
            }
        }
    }
}
