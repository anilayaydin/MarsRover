using System;
using MarsRover.Domain.Entities;  
namespace MarsRover.Application.Interfaces
{
    public interface IPlateau
    {
        Position PlateauPosition { get; }
    }
}