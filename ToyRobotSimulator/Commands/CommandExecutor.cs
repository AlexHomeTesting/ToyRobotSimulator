using System.Collections.Generic;
using ToyRobotSimulator.Model;
using ToyRobotSimulator.Robot.Interface;

namespace ToyRobotSimulator
{
    public class CommandExecutor
    {
        public IRobot Robot { get; set; }

        private Queue<CommandData> commands;

        public CommandExecutor(IRobot robot, Queue<CommandData> commands)
        {
            this.commands = new Queue<CommandData>();
            this.commands = commands;
            this.Robot = robot;
        }

        public void Execute()
        {
            foreach (var command in commands)
            {
                Execute(command);
            }
        }

        private void Execute(CommandData command)
        {
            switch (command.commandType)
            {
                case CommandTypes.PLACE:
                    {
                        if (!Robot.IsPlaced)
                            Robot.IsPlaced = true;
                        Robot.Place(command.X, command.Y, command.FacingDirection);
                    }
                    break;
                case CommandTypes.MOVE:
                    Robot.Move();
                    break;
                case CommandTypes.RIGHT:
                    Robot.Right();
                    break;
                case CommandTypes.LEFT:
                    Robot.Left();
                    break;
                case CommandTypes.REPORT:
                    Robot.Report();
                    break;
                default:
                    break;
            }
        }
    }
}
