
namespace ToyRobotSimulator.Logger.Interface
{
    public interface ILogging
    {
        void Report(string toyRobotState);
        void Warn(string warningMessage);
        void Error(string errorMessage);
    }
}
