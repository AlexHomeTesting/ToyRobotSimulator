using ToyRobotSimulator.Directions;
using ToyRobotSimulator.Directions.Interface;
using ToyRobotSimulator.Logger.Interface;
using ToyRobotSimulator.Robot.Interface;

namespace ToyRobotSimulator.Robot
{
    public class ToyRobot : IRobot
    {
        public bool IsPlaced { get; set; }
        public FacingDirection facingDirection { get ; set ; }

        private static IDirectionCalculator directionCalculator;
        private Coordinates coordinates;
        private ILogging loggingService;

        public ToyRobot(ILogging loggingService)
        {
            this.loggingService = loggingService;
        }

        public void Move()
        {
            if (IsPlaced)
            {
                directionCalculator = DirectionFactory.GetDirectionCalculator(facingDirection);
                coordinates = directionCalculator.GoForward(coordinates);
            }
        }

        public void Place(int x, int y, FacingDirection facingDirection)
        {
            coordinates.X = x;
            coordinates.Y = y;
            this.facingDirection = facingDirection;
        }

        public void Report()
        {
            if (IsPlaced)
            {
                loggingService.Report($"{coordinates.X},{coordinates.Y},{facingDirection}");
            }
        }

        public void Left()
        {
            if (IsPlaced)
            {
                directionCalculator = DirectionFactory.GetDirectionCalculator(facingDirection);
                facingDirection = directionCalculator.TurnLeft();
            }
        }

        public void Right()
        {
            if (IsPlaced)
            {
                directionCalculator = DirectionFactory.GetDirectionCalculator(facingDirection);
                facingDirection = directionCalculator.TurnRight();
            }
        }
    }
}
