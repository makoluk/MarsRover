using MarsRover;
using NUnit.Framework;
using System;

namespace MarsRoverTests
{
    public class RoverTest
    {
        [Test]
        public void Given_Rover_Direction_Is_North_When_SpinLeft_Called_Then_Direction_Is_West()
        {
            Rover rover = new Rover(1, 1, Direction.N, 0, 0, 5, 5);

            rover.SpinLeft();

            Assert.AreEqual(Direction.W, rover.Direction);
        }

        [Test]
        public void Given_Rover_Direction_Is_West_When_SpinLeft_Called_Then_Direction_Is_South()
        {
            Rover rover = new Rover(1, 1, Direction.W, 0, 0, 5, 5);

            rover.SpinLeft();

            Assert.AreEqual(Direction.S, rover.Direction);
        }

        [Test]
        public void Given_Rover_Direction_Is_South_When_SpinLeft_Called_Then_Direction_Is_East()
        {
            Rover rover = new Rover(1, 1, Direction.S, 0, 0, 5, 5);

            rover.SpinLeft();

            Assert.AreEqual(Direction.E, rover.Direction);
        }

        [Test]
        public void Given_Rover_Direction_Is_East_When_SpinLeft_Called_Then_Direction_Is_North()
        {
            Rover rover = new Rover(1, 1, Direction.E, 0, 0, 5, 5);

            rover.SpinLeft();

            Assert.AreEqual(Direction.N, rover.Direction);
        }

        [Test]
        public void Given_Rover_Direction_Is_North_When_SpinRight_Called_Then_Direction_Is_East()
        {
            Rover rover = new Rover(1, 1, Direction.N, 0, 0, 5, 5);

            rover.SpinRight();

            Assert.AreEqual(Direction.E, rover.Direction);
        }

        [Test]
        public void Given_Rover_Direction_Is_East_When_SpinRight_Called_Then_Direction_Is_South()
        {
            Rover rover = new Rover(1, 1, Direction.E, 0, 0, 5, 5);

            rover.SpinRight();

            Assert.AreEqual(Direction.S, rover.Direction);
        }

        [Test]
        public void Given_Rover_Direction_Is_South_When_SpinRight_Called_Then_Direction_Is_West()
        {
            Rover rover = new Rover(1, 1, Direction.S, 0, 0, 5, 5);

            rover.SpinRight();

            Assert.AreEqual(Direction.W, rover.Direction);
        }

        [Test]
        public void Given_Rover_Direction_Is_West_When_SpinRight_Called_Then_Direction_Is_North()
        {
            Rover rover = new Rover(1, 1, Direction.W, 0, 0, 5, 5);

            rover.SpinRight();

            Assert.AreEqual(Direction.N, rover.Direction);
        }

        [Test]
        public void Given_Rover_When_Move_Command_Is_Not_Valid_Then_Throw_Exception()
        {
            Rover rover = new Rover(1, 1, Direction.W, 0, 0, 5, 5);

            Assert.Throws<ArgumentException>(() => rover.Move("LLMMXX"));
        }

        [Test]
        public void Given_Rover_Direction_Is_North_When_MoveForward_Called_Rover_Y_Coordinate_Increases_By_One()
        {
            Rover rover = new Rover(1, 1, Direction.N, 0, 0, 5, 5);
            rover.Move("M");
            Assert.AreEqual(2, rover.YCoordinateOfRover);
        }

        [Test]
        public void Given_Rover_Direction_Is_South_When_MoveForward_Called_Rover_Y_Coordinate_Decreases_By_One()
        {
            Rover rover = new Rover(1, 1, Direction.S, 0, 0, 5, 5);
            rover.Move("M");
            Assert.AreEqual(0, rover.YCoordinateOfRover);
        }

        [Test]
        public void Given_Rover_Direction_Is_East_When_MoveForward_Called_Rover_X_Coordinate_Increases_By_One()
        {
            Rover rover = new Rover(1, 1, Direction.E, 0, 0, 5, 5);
            rover.Move("M");
            Assert.AreEqual(2, rover.XCoordinateOfRover);
        }

        [Test]
        public void Given_Rover_Direction_Is_West_When_MoveForward_Called_Rover_X_Coordinate_Decreases_By_One()
        {
            Rover rover = new Rover(1, 1, Direction.W, 0, 0, 5, 5);
            rover.Move("M");
            Assert.AreEqual(0, rover.XCoordinateOfRover);
        }

        [Test]
        public void Given_Rover_Going_Out_Plateau_When_MoveForward_Called_Then_Throw_Exception()
        {
            Rover rover = new Rover(0, 0, Direction.W, 0, 0, 5, 5);

            Assert.Throws<ArgumentException>(() => rover.Move("M"));
        }
    }
}