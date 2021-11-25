using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserRegistration
{
    [TestClass]
    public class UserRegistrationTestMethod
    {
        //First Name valid or not
        [TestMethod]
        public void TestingFirstNameValid()
        {

            //Arrange
            string fname = "Son";
            string expected = "valid";
            string actual;
            //Act
            actual = RegexValidate.FirstName(fname);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestingFirstNameInvalid()
        {
            try
            {
                //Arrange
                string fname = "sonu";
                string expected = "invalid";
                string actual;
                //Act
                actual = RegexValidate.FirstName(fname);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("invalid", e.Message);
            }
        }
        [TestMethod]
        //The following test case should return Invalid  as entry is null
        public void TestFirstName_NullException()
        {
            string fname = null;
            try
            {
                //Arrange

                string expected = "Invalid";                       //this returns invalid since the minimum letter in first name should be 3

                //Act
                string reg = RegexValidate.FirstName(fname);          //since sstatic methods so no need of class obj creation

                //Assert
                expected.Equals(reg);

            }
            catch (CustomException e)
            {
                Assert.AreEqual("Entry cannot be null", e.Message);
            }
        }

        //Last Name valid or not
        [TestMethod]
        public void TestingLastNamevalid()
        {
            //Arrange
            string fname = "son";
            string expected = "valid";
            string actual;
            //Act
            actual = RegexValidate.LastName(fname);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestingLastNameInvalid()
        {
            try
            {
                //Arrange
                string fname = "sharma";
                string expected = "invalid";
                string actual;
                //Act
                actual = RegexValidate.LastName(fname);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException e)

            {
                Assert.AreEqual("invalid", e.Message);
            }
        }
        [TestMethod]
        //The following test case should return excepiton as argument null
        public void TestLastName_NullExeption()
        {
            try
            {
                //Arrange
                string name = null;                 //This returns invalid as the first letter is not capital
                string expected = "Invalid";

                //Act
                string reg = RegexValidate.LastName(name);

                //Assert
                Assert.AreEqual(expected, reg);

            }
            catch (CustomException e)
            {
                Assert.AreEqual("Entry cannot be null", e.Message);
            }

        }

        //phone no valid or not
        [TestMethod]
        public void MobileNumValid()
        {
            //Arrange
            string fname = "91 9113127494";
            string expected = "valid";
            string actual;
            //Act
            actual = RegexValidate.MobileNumValid(fname);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MobileNumInValid()
        {
            try
            {
                //Arrange
                string fname = "19113127494";
                string expected = "invalid";
                string actual;
                //Act
                actual = RegexValidate.MobileNumValid(fname);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("invalid", e.Message);
            }
        }
        [TestMethod]

        //The following test case should return null exception
        public void TestPhoneNumber_NullException()
        {
            try
            {
                //Arrange
                string name = null;                    //since there is no country code
                string expected = "Invalid";

                //Act
                string reg = RegexValidate.MobileNumValid(name);

                //Assert
                Assert.AreEqual(expected, reg);
            }
            catch (CustomException e)                          //Argument null exception
            {
                Assert.AreEqual("Entry cannot be null", e.Message);
            }

        }

        //Fpassword valid or not
        [TestMethod]
        public void Validpassword()
        {
            //Arrange
            string fname = "a@12sonu";
            string expected = "valid";
            string actual;
            //Act
            actual = RegexValidate.PassWord(fname);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InValidpassword()
        {
            try
            {
                //Arrange
                string fname = "ancvbnmmk@";
                string expected = "invalid";
                string actual;
                //Act
                actual = RegexValidate.PassWord(fname);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("invalid", e.Message);
            }
        }
        public void TestPassword_NullException()
        {
            try
            {
                //Arrange
                string name = null;                     //Missing atleast one number, and special character
                string expected = "Invalid";

                //Act
                string reg = RegexValidate.PassWord(name);

                //Assert
                Assert.AreEqual(expected, reg);

            }
            catch (CustomException e)
            {
                Assert.AreEqual("Entry cannot be null", e.Message);
            }

        }

        [TestMethod]
        //valid email 
        [DataTestMethod]     //for testing multiple data

        [DataRow("abc@gmail.com")]
        [DataRow("1.abc@yahoo.com")]
        [DataRow("2.abc-100@yahoo.com")]
        [DataRow("3.abc.100@yahoo.com")]
        [DataRow("2.abc111@abc.com")]
        [DataRow("4.abc-100@abc.net")]
        [DataRow("5.abc.100@abc.com.au")]
        [DataRow("6.abc@1.com")]
        [DataRow("7.abc@gmail.com.com")]
        [DataRow("8.abc+100@gmail.com")]
        public void Testemail_Valid(string name)
        {
            //Arrange
            string expected = "valid";

            //Act
            string actual = RegexValidate.EmailValid(name);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        //Invalid email 
        [DataTestMethod]     //for testing multiple data

        [DataRow("abc")]
        [DataRow("abc@.com.my")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@.com.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc()*@gmail.com")]
        [DataRow("abc@%*.com")]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@gmail.com.aa.au")]

        public void Testemail_Invalid(string name)
        {
            try
            {
                //Arrange
                string expected = "invalid";

                //Act
                string actual = RegexValidate.EmailValid(name);

                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("invalid", e.Message);
            }
        }
        [TestMethod]
        public void TestEmail_NullException()                   //argument null excewption.
        {
            try
            {
                string email = null;
                string reg = RegexValidate.EmailValid(email);
                Assert.AreEqual("Valid", reg);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Entry cannot be null", e.Message);
            }
        }

    }
}
