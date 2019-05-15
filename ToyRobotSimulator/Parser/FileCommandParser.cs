using System;
using System.Collections.Generic;
using System.IO;
using ToyRobotSimulator.Commands;
using ToyRobotSimulator.Logger.Interface;
using ToyRobotSimulator.Model;
using ToyRobotSimulator.Parser.Interface;
using ToyRobotSimulator.Common;

namespace ToyRobotSimulator.Parser
{
    public class FileCommandParser : ICommandParser
    {
        private string filePath;
        private ILogging loggingService;
        private const int ReadedXPosition = 0;
        private const int ReadedYPosition = 1;
        private const int ReadedFacingPosition = 2;

        public Queue<CommandData> CommandsQueue { get; set; }

        public FileCommandParser(ILogging loggingService, string filepath = GeneralConstants.CommandsFilePath)
        {
            this.filePath = filepath;
            this.loggingService = loggingService;
            CommandsQueue = new Queue<CommandData>();
        }

        public void ReadCommands()
        {
            if (!FileExits())
            {
                loggingService.Warn($"FileCommandParser->ReadCommands() : {filePath} does not exists.");
                return;
            }

            var lineCommands = new string[] { };
            try
            {
                lineCommands = File.ReadAllLines(filePath);
            }
            catch (IOException ex)
            {
                loggingService.Warn($"FileCommandParser->ReadCommands() : {ex.Message}");
            }

            ParseCommands(lineCommands);
        }

        private void ParseCommands(string[] commands)
        {
            foreach (var command in commands)
            {
                var commandData = new CommandData();
                if (command.Contains("PLACE"))
                {
                    if (CommandValidation.IsPlaceCommandValid(command))
                    {
                        var split = command.Split(' ');
                        var values = split[1].Split(',');
                        commandData.X = Convert.ToInt16(values[ReadedXPosition]);
                        commandData.Y = Convert.ToInt16(values[ReadedYPosition]);

                        commandData.commandType = CommandTypes.PLACE;
                        var parseSuccess = Enum.TryParse(values[ReadedFacingPosition], out commandData.FacingDirection);
                        if (!parseSuccess)
                            continue;
                    }
                }
                else
                {
                    var parseSuccess = Enum.TryParse(command, out commandData.commandType);
                    if (!parseSuccess)
                        continue;
                }
                CommandsQueue.Enqueue(commandData);
            }
        }

        private bool FileExits()
        {
            if (File.Exists(filePath))
                return true;
            return false;
        }
    }
}
