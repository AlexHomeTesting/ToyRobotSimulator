using ToyRobotSimulator.Common;
using ToyRobotSimulator.Directions.Interface;
using ToyRobotSimulator.Robot;

namespace ToyRobotSimulator.Directions
{
    public class EastDirection : IDirectionCalculator
    {
        public Coordinates GoForward(Coordinates currentCoordinates)
        {
            if (currentCoordinates.X < GeneralConstants.XMaxValue)
                currentCoordinates.X++;
            return currentCoordinates;
        }

        public FacingDirection TurnLeft()
        {
            return FacingDirection.NORTH;
        }

        public FacingDirection TurnRight()
        {
            return FacingDirection.SOUTH;
        }
    }
}
