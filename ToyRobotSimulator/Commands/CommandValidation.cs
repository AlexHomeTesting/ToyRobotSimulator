using System.Text.RegularExpressions;

namespace ToyRobotSimulator.Commands
{
    public static class CommandValidation
    {
        public static bool IsPlaceCommandValid(string command)
        {
            var pattern = @"[A-Za-z]+[\s]+(\b[0-4]\b)+[,]+(\b[0-4]\b)+[,]+[A-Za-z]";
            var regex = new Regex(pattern);
            var match = regex.Match(command);
            return match.Success;
        }
    }
}
