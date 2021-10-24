using System;
using MarsRover.Domain;
using MarsRover.Application.Interfaces;
namespace MarsRover.Application.Models
{
    public class Rover : IRover
    {
        public IPlateau RoverPlateau { get; set; }
        public IPosition RoverPosition { get; set; }
        public Directions RoverDirection { get; set; }


        public Rover(IPlateau roverPlateau, IPosition roverPosition, Directions roverDirection)
        {
            RoverPlateau = roverPlateau;
            RoverPosition = roverPosition;
            RoverDirection = roverDirection;
        }

        public void Process(string commands)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case ('L'):
                        TurnLeft();
                        break;
                    case ('R'):
                        TurnRight();
                        break;
                    case ('M'):
                        Move();
                        break;
                    default:
                        throw new ArgumentException(string.Format("Invalid value: {0}", command));
                }
            }
        }

        private void TurnLeft()
        {
            RoverDirection = (RoverDirection - 1) < Directions.N ? Directions.W : RoverDirection - 1;
        }

        private void TurnRight()
        {
            RoverDirection = (RoverDirection + 1) > Directions.W ? Directions.N : RoverDirection + 1;
        }

        private void Move()
        {
            if (RoverDirection == Directions.N)
            {
                RoverPosition.y++;
            }
            else if (RoverDirection == Directions.E)
            {
                RoverPosition.x++;
            }
            else if (RoverDirection == Directions.S)
            {
                RoverPosition.y--;
            }
            else if (RoverDirection == Directions.W)
            {
                RoverPosition.x--;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", RoverPosition.x, RoverPosition.y, RoverDirection);
        }
        
    }
}
