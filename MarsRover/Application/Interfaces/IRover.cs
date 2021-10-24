using System;

namespace MarsRover.Application.Interfaces
{
    public interface IRover
    {
            IPlateau RoverPlateau { get; set; }
            IPosition RoverPosition { get; set; }
            Directions RoverDirection { get; set; }
            void Process(string commands);
            string ToString();
    }
}