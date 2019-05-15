using ToyRobotSimulator.Common;
using ToyRobotSimulator.Directions.Interface;
using ToyRobotSimulator.Robot;

namespace ToyRobotSimulator.Directions
{
    public class NorthDirection : IDirectionCalculator
    {
        public Coordinates GoForward(Coordinates currentCoordinates)
        {
            if (currentCoordinates.Y < GeneralConstants.YMaxValue)
                currentCoordinates.Y++;
            return currentCoordinates;
        }

        public FacingDirection TurnLeft()
        {
            return FacingDirection.WEST;
        }

        public FacingDirection TurnRight()
        {
            return FacingDirection.EAST;
        }
    }
}
