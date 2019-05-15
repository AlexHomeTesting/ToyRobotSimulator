
namespace ToyRobotSimulator.Robot.Interface
{
    public interface IRobot
    {
        bool IsPlaced { get; set; }
        void Place(int x, int y, FacingDirection facingDirection);
        void Move();
        void Right();
        void Left();
        void Report();
    }
}
