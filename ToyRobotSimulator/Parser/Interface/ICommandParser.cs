using System.Collections.Generic;
using ToyRobotSimulator.Model;

namespace ToyRobotSimulator.Parser.Interface
{
    public interface ICommandParser
    {
        void ReadCommands();
        Queue<CommandData> CommandsQueue { get; set; }
    }
}
