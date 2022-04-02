using System;
using System.Collections.Generic;

namespace MarsRover
{
    public class Plateau
    {
        public int MinimumXCoordinate;
        public int MinimumYCoordinate;
        public int MaximumXCoordinate;
        public int MaximumYCoordinate;
        public List<Rover> Rovers { get; set; }

        public Plateau()
        {
            MinimumXCoordinate = 0;
            MinimumYCoordinate = 0;
            Rovers = new List<Rover>();
        }

        public void CreatePlateau(string createPlateauCommand)
        {
            if (!int.TryParse(createPlateauCommand.Split(" ")[0], out MaximumXCoordinate))
            {
                throw new ArgumentException("An error occured getting coordinates");
            }
            if (!int.TryParse(createPlateauCommand.Split(" ")[1], out MaximumYCoordinate))
            {
                throw new ArgumentException("An error occured getting coordinates");
            }
        }

        public Rover AddRover(string initializeRoverCommand)
        {
            if (!int.TryParse(initializeRoverCommand.Split(" ")[0], out int x))
            {
                throw new ArgumentException("An error occured getting coordinates");
            }

            if (!int.TryParse(initializeRoverCommand.Split(" ")[1], out int y))
            {
                throw new ArgumentException("An error occured getting coordinates");
            }

            if (!Enum.TryParse(initializeRoverCommand.Split(" ")[2], out Direction direction))
            {
                throw new ArgumentException("An error occured getting direction");
            }

            if (MinimumXCoordinate > x || MaximumXCoordinate < x || MinimumYCoordinate > y || MaximumYCoordinate < y)
                throw new Exception("An error occured adding rover");
            else
            {
                var rover = new Rover(x, y, direction, MinimumXCoordinate, MinimumYCoordinate, MaximumXCoordinate, MaximumYCoordinate);
                Rovers.Add(rover);
                return rover;
            }
        }
    }
}