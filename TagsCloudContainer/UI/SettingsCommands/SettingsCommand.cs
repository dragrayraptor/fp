﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TagsCloudContainer.UI.SettingsCommands
{
    public abstract class SettingsCommand : ISettingsCommand
    {
        public abstract string Name { get; }

        public Result<string[]> GetArguments(string input)
        {
            var arguments = input.Split(' ');
            if (arguments.Length == 0 || arguments[0] != Name)
                return Result.Fail<string[]>("This input is not for this command");
            return arguments.AsResult();
        }

        public abstract Result<IInitialSettings> TryChangeSettings(string[] arguments, IInitialSettings settings);
    }
}
