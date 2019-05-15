using Ninject.Modules;
using ToyRobotSimulator.Logger;
using ToyRobotSimulator.Logger.Interface;
using ToyRobotSimulator.Parser;
using ToyRobotSimulator.Parser.Interface;
using ToyRobotSimulator.Robot;
using ToyRobotSimulator.Robot.Interface;

namespace ToyRobotSimulator.IoC
{
    public class IoCBootstrapper : NinjectModule
    {
        public override void Load()
        {
            Bind<ICommandParser>().To<FileCommandParser>();
            Bind<ILogging>().To<ConsoleLogging>();
            Bind<IRobot>().To<ToyRobot>();
        }
    }
}
