using System;
using System.Collections.Generic;
using System.Text;

using Dealership.Contracts;
using Dealership.Contracts.Engine;
using Dealership.Contracts.Factories;
using Dealership.Contracts.Handlers;
using Dealership.Contracts.IO;

namespace Dealership.Engine
{
    public sealed class DealershipEngine : IDealershipEngine
    {
        private IReader reader;
        private IWriter writer;
        private ICommandHandler commandHandler;

        public DealershipEngine(IDealershipFactory factory, ICommandHandler commandHandler, IReader reader, IWriter writer)
        {
            this.Factory = factory;
            this.commandHandler = commandHandler;
            this.reader = reader;
            this.writer = writer;
            this.Users = new List<IUser>();
            this.LoggedUser = null;
        }

        public IUser LoggedUser { get; set; }

        public ICollection<IUser> Users { get; private set; }

        public IDealershipFactory Factory { get; private set; }

        public void Start()
        {
            var commands = this.ReadCommands();
            var commandResult = this.ProcessCommands(commands);
            this.PrintReports(commandResult);
        }

        public void Reset(IDealershipFactory factory)
        {
            this.Factory = factory;
            this.Users = new List<IUser>();
            this.LoggedUser = null;
            var commands = new List<ICommand>();
            var commandResult = new List<string>();
            this.PrintReports(commandResult);
        }

        private IList<ICommand> ReadCommands()
        {
            var commands = new List<ICommand>();
            var input = this.reader.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                var currentCommand = this.Factory.CreateCommand(input);
                commands.Add(currentCommand);

                input = this.reader.ReadLine();
            }

            return commands;
        }

        private IList<string> ProcessCommands(IList<ICommand> commands)
        {
            var reports = new List<string>();

            foreach (var command in commands)
            {
                try
                {
                    var report = this.commandHandler.HandleCommand(command, this);
                    reports.Add(report);
                }
                catch (Exception ex)
                {
                    reports.Add(ex.Message);
                }
            }

            return reports;
        }

        private void PrintReports(IList<string> reports)
        {
            var output = new StringBuilder();

            foreach (var report in reports)
            {
                output.AppendLine(report);
                output.AppendLine(new string('#', 20));
            }

            this.writer.Write(output.ToString());
        }
    }
}
