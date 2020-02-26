using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace MMonteiroAssignment2.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
        /// <summary>
        /// Tests for an input where the three sides cannot make a triangle
        /// </summary>
        [Test]
        public void Analyze_ThreeIntegersDoNotMakeTriangle_InvalidTriangleMessage()
        {
            //Arrange
            string message = "Input values do not make a triangle";
            int side1 = 1;
            int side2 = 2;
            int side3 = 8;

            //Act
            string response = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(message, response);
        }

        /// <summary>
        /// Tests for an input where at least one side entered is negative
        /// </summary>
        [Test]
        public void Analyze_AtLeastOneIntegerLessThan1_NegativeIntegerMessage()
        {
            //Arrange
            string message = "All sides must be greater than 0";
            int side1 = 1;
            int side2 = 1;
            int side3 = -1;

            //Act
            string response = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(message, response);
        }

        /// <summary>
        /// Tests for an input where all sides entered are negative
        /// </summary>
        [Test]
        public void Analyze_AllIntegersLessThan1_NegativeIntegerMessage()
        {
            //Arrange
            string message = "All sides must be greater than 0";
            int side1 = -1;
            int side2 = -1;
            int side3 = -1;

            //Act
            string response = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(message, response);
        }

        /// <summary>
        /// Tests for an input where an equalateral triangle is produced
        /// </summary>
        [Test]
        public void Analyze_AllSidesEqual_EqualateralTriangleMessage()
        {
            //Arrange
            string message = "This is a valid equalateral triangle";
            int side1 = 1;
            int side2 = 1;
            int side3 = 1;

            //Act
            string response = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(message, response);
        }

        /// <summary>
        /// Tests for an input where an isoceles triangle is produced
        /// </summary>
        [Test]
        public void Analyze_TwoSidesEqual_IsocelesTriangleMessage()
        {
            //Arrange
            string message = "This is a valid isoceles triangle";
            int side1 = 20;
            int side2 = 20;
            int side3 = 12;

            //Act
            string response = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(message, response);
        }

        /// <summary>
        /// Tests for an input where a scalene triangle is produced
        /// </summary>
        [Test]
        public void Analyze_NoSidesEqual_ScaleneTriangleMessage()
        {
            //Arrange
            string message = "This is a valid scalene triangle";
            int side1 = 20;
            int side2 = 19;
            int side3 = 12;

            //Act
            string response = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(message, response);
        }
    }
}
