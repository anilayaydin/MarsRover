using System;
using MarsRover.Application.Interfaces;

namespace MarsRover.Domain.Entities
{

    public class Position : IPosition
    {
        public int x { get; set; }
        public int y { get; set; }

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}