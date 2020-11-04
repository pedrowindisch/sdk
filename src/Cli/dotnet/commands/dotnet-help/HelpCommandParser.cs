﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.CommandLine;
using System.CommandLine.Invocation;
using System.CommandLine.Parsing;

namespace Microsoft.DotNet.Tools.Help
{
    internal static class HelpCommandParser
    {
        public static readonly Argument Argument = new Argument(LocalizableStrings.CommandArgumentName)
        {
            Description = LocalizableStrings.CommandArgumentDescription,
            Arity = ArgumentArity.ZeroOrOne
        };

        public static Command GetCommand()
        {
            var command = new Command("help", LocalizableStrings.AppFullName);

            command.AddArgument(Argument);

            return command;
        }
    }
}

