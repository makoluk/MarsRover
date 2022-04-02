using System;

namespace MarsRover
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var platteau = new Plateau();
            platteau.CreatePlateau("5 5");
            var rover1 = platteau.AddRover("1 2 N");
            rover1.Move("LMLMLMLMM");
            var rover2 = platteau.AddRover("3 3 E");
            rover2.Move("MMRMMRMRRM");
            foreach (var item in platteau.Rovers)
            {
                Console.WriteLine(item.XCoordinateOfRover + " " + item.YCoordinateOfRover + " " + item.Direction);
            }
        }
    }
}