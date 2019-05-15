using ToyRobotSimulator.Common;
using ToyRobotSimulator.Directions.Interface;
using ToyRobotSimulator.Robot;

namespace ToyRobotSimulator.Directions
{
    public class WestDirection : IDirectionCalculator
    {
        public Coordinates GoForward(Coordinates currentCoordinates)
        {
            if (currentCoordinates.X > GeneralConstants.XMinValue)
                currentCoordinates.X--;
            return currentCoordinates;
        }

        public FacingDirection TurnLeft()
        {
            return FacingDirection.SOUTH;
        }

        public FacingDirection TurnRight()
        {
            return FacingDirection.NORTH;
        }
    }
}
