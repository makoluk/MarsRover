using System;

namespace MarsRover
{
    public class Rover
    {
        private readonly int MinimumXCoordinate;
        private readonly int MinimumYCoordinate;
        private readonly int MaximumXCoordinate;
        private readonly int MaximumYCoordinate;
        public int XCoordinateOfRover { get; set; }
        public int YCoordinateOfRover { get; set; }
        public Direction Direction { get; set; }

        public Rover(int x, int y, Direction direction, int minimumXCoordinate, int minimumYCoordinate, int maximumXCoordinate, int maximumYCoordinate)
        {
            XCoordinateOfRover = x;
            YCoordinateOfRover = y;
            Direction = direction;
            MinimumXCoordinate = minimumXCoordinate;
            MinimumYCoordinate = minimumYCoordinate;
            MaximumXCoordinate = maximumXCoordinate;
            MaximumYCoordinate = maximumYCoordinate;
        }

        public void SpinLeft()
        {
            switch (Direction)
            {
                case Direction.N:
                    Direction = Direction.W;
                    break;

                case Direction.W:
                    Direction = Direction.S;
                    break;

                case Direction.S:
                    Direction = Direction.E;
                    break;

                case Direction.E:
                    Direction = Direction.N;
                    break;

                default:
                    break;
            }
        }

        public void SpinRight()
        {
            switch (Direction)
            {
                case Direction.N:
                    Direction = Direction.E;
                    break;

                case Direction.E:
                    Direction = Direction.S;
                    break;

                case Direction.S:
                    Direction = Direction.W;
                    break;

                case Direction.W:
                    Direction = Direction.N;
                    break;

                default:
                    break;
            }
        }

        public void MoveForward()
        {
            switch (Direction)
            {
                case Direction.N:
                    YCoordinateOfRover += 1;
                    break;

                case Direction.W:
                    XCoordinateOfRover -= 1;
                    break;

                case Direction.E:
                    XCoordinateOfRover += 1;
                    break;

                case Direction.S:
                    YCoordinateOfRover -= 1;
                    break;

                default:
                    break;
            }
            ValidateRoverCoordinate();
        }

        private void ValidateRoverCoordinate()
        {
            if (XCoordinateOfRover < MinimumXCoordinate || YCoordinateOfRover < MinimumYCoordinate || XCoordinateOfRover > MaximumXCoordinate || YCoordinateOfRover > MaximumYCoordinate)
            {
                throw new ArgumentException("Rover is going out of the plateau");
            }
        }

        public void Move(string moveCommand)
        {
            char[] instructions = moveCommand.ToCharArray();
            for (int i = 0; i < instructions.Length; i++)
            {
                switch (instructions[i])
                {
                    case Command.SpinLeft:
                        SpinLeft();
                        break;

                    case Command.SpinRight:
                        SpinRight();
                        break;

                    case Command.MoveForward:
                        MoveForward();
                        break;

                    default:
                        throw new ArgumentException("Instrations is not valid");
                };
            }
        }
    }
}