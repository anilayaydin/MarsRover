using System;
using MarsRover.Application.Interfaces;
namespace MarsRover.Domain.Entities
{
    public class Plateau : IPlateau
    {
        public Position PlateauPosition { get; private set; }

        public Plateau(Position position)
        {
            PlateauPosition = position;
        }
    }  
}