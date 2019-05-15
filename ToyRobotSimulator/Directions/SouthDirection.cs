using ToyRobotSimulator.Common;
using ToyRobotSimulator.Directions.Interface;
using ToyRobotSimulator.Robot;

namespace ToyRobotSimulator.Directions
{
    public class SouthDirection : IDirectionCalculator
    {
        public Coordinates GoForward(Coordinates currentCoordinates)
        {
            if (currentCoordinates.Y > GeneralConstants.YMinValue)
                currentCoordinates.Y--;
            return currentCoordinates;
        }

        public FacingDirection TurnLeft()
        {
            return FacingDirection.EAST;
        }

        public FacingDirection TurnRight()
        {
            return FacingDirection.WEST;
        }
    }
}
