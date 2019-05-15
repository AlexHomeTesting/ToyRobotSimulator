using Ninject;
using System.Reflection;
using ToyRobotSimulator.Parser.Interface;
using ToyRobotSimulator.Robot.Interface;

namespace ToyRobotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var parser = kernel.Get<ICommandParser>();
            parser.ReadCommands();
            var commandExecutor = new CommandExecutor(kernel.Get<IRobot>(), parser.CommandsQueue);
            commandExecutor.Execute();
        }
    }
}
