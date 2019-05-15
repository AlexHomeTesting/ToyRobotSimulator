using ToyRobotSimulator.Directions.Interface;

namespace ToyRobotSimulator.Directions
{
    public static class DirectionFactory
    {
        public static IDirectionCalculator GetDirectionCalculator(FacingDirection facingDirection)
        {
            switch (facingDirection)
            {
                case FacingDirection.NORTH:
                    return new NorthDirection();
                case FacingDirection.SOUTH:
                    return new SouthDirection();
                case FacingDirection.EAST:
                    return new EastDirection();
                case FacingDirection.WEST:
                    return new WestDirection();
                default:
                    return new NorthDirection();
            }
        }
    }
}
