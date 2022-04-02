using MarsRover;
using NUnit.Framework;
using System;

namespace MarsRoverTests
{
    public class PlateauTest
    {
        [Test]
        public void Given_CreatePlateauCommand_Is_Valid_When_CreatePlateau_Called_Then_Set_Plateau_Coordinates()
        {
            Plateau plateau = new Plateau();
            plateau.CreatePlateau("5 5");
            Assert.AreEqual(5, plateau.MaximumXCoordinate);
            Assert.AreEqual(5, plateau.MaximumYCoordinate);
        }

        [Test]
        public void Given_CreatePlateauCommand_Is_Not_Valid_When_CreatePlateau_Called_Then_Throw_Exception()
        {
            Plateau plateau = new Plateau();
            Assert.Throws<ArgumentException>(() => plateau.CreatePlateau("5 N"));
        }

        [Test]
        [TestCase("A")]
        [TestCase("1 2 X")]
        [TestCase("N 4 W")]
        public void Given_InitializeRoverCommand_Is_Not_Valid_When_AddRover_Called_Then_Throw_Exception(string initializeRoverCommand)
        {
            Plateau plateau = new Plateau();
            Assert.Throws<ArgumentException>(() => plateau.AddRover(initializeRoverCommand));
        }

        [Test]
        public void Given_InitializeRoverCommand_Is_Valid_And_Rover_Coordinates_Are_Not_Valid_When_AddRover_Called_Then_Throw_Exception()
        {
            Plateau plateau = new Plateau();
            plateau.CreatePlateau("5 5");
            Assert.Throws<Exception>(() => plateau.AddRover("6 6 N"));
        }

        [Test]
        public void Given_InitializeRoverCommand_Is_Valid_And_Rover_Coordinates_Are_Valid_When_AddRover_Called_Then_Add_Rover()
        {
            Plateau plateau = new Plateau();
            plateau.CreatePlateau("5 5");
            plateau.AddRover("4 4 N");
            Assert.AreEqual(1, plateau.Rovers.Count);
        }
    }
}