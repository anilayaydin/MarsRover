using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover.Application.Interfaces;
using MarsRover.Application.Models;
using MarsRover.Domain.Entities;
using System;

namespace MarsRoverTests
{
    [TestClass]
    public class MarsRoverTest
    {
        [TestClass]
        public class TestOfMarsRover
        {
            /// <summary>
            /// Test method for First Rover check output
            /// </summary>
            [TestMethod]
            public void FirstRoverCheckOutput()
            {
                Plateau plateauOne = new Plateau(new Position(5, 5));
                Rover firstRover = new Rover(plateauOne, new Position(1, 2), Directions.N);
                firstRover.Process("LMLMLMLMM");
                Assert.AreEqual(firstRover.ToString(), "1 3 N");
            }

            /// <summary>
            /// Test method for Second Rover check output
            /// </summary>
            [TestMethod]
            public void SecondRoverCheckOutput()
            {
                Plateau plateauTwo = new Plateau(new Position(5, 5));
                Rover secondRover = new Rover(plateauTwo, new Position(3, 3), Directions.E);
                secondRover.Process("MMRMMRMRRM");
                Assert.AreEqual(secondRover.ToString(), "5 1 E");
            }

            /// <summary>
            /// Test method for incorrect input
            /// </summary>
            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void IncorrectInput()
            {
                Plateau plateauOne = new Plateau(new Position(5, 5));
                Rover firstRover = new Rover(plateauOne, new Position(1, 2), Directions.N);
                firstRover.Process("LMAMMM");
            }
        }
    }
}
