using System;
using ToyRobotSimulator.Logger.Interface;

namespace ToyRobotSimulator.Logger
{
    public class ConsoleLogging : ILogging
    {
        public void Report(string toyRobotState)
        {
            Console.WriteLine($"Output: {toyRobotState}");
        }

        public void Warn(string warningMessage)
        {
            Console.WriteLine($"WARN: {warningMessage}");
        }

        public void Error(string errorMessage)
        {
            Console.WriteLine($"Error: {errorMessage}");
        }
    }
}
