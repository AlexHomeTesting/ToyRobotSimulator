using ToyRobotSimulator.Robot;

namespace ToyRobotSimulator.Directions.Interface
{
    public interface IDirectionCalculator
    {
        FacingDirection TurnLeft();
        FacingDirection TurnRight();
        Coordinates GoForward(Coordinates currentCoordinates);
    }
}
