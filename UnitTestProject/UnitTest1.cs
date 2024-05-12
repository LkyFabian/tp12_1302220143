using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tp12_1302220143.Form1;



namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(-5, "Negatif")] // Input negatif
        [DataRow(5, "Positif")]  // Input positif
        [DataRow(0, "Nol")]      // Input nol
        public void CariTandaBilangan_ValidInput_ReturnsExpected(int input, string expectedOutput)
        {
            // Arrange
            Form1 form = new Form1 ();

            // Act
            string actualOutput = form.CariTandaBilangan(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
