using Ninject.Modules;
using SchoolSystem.Framework.Core.Contracts;
using SchoolSystem.Framework.Core.Providers;

namespace SchoolSystem.Framework.Core
{
    public class EngineModule : NinjectModule
    {
        private readonly CommandParserProvider commandParserProvider;
        private readonly ConsoleReaderProvider consoleReaderProvider;
        private readonly ConsoleWriterProvider consoleWriterProvider;

        public EngineModule(ConsoleReaderProvider consoleReaderProvider, 
            ConsoleWriterProvider consoleWriterProvider, CommandParserProvider commandParserProvider)
        {
            this.consoleReaderProvider = consoleReaderProvider;
            this.consoleWriterProvider = consoleWriterProvider;
            this.commandParserProvider = commandParserProvider;
        }

        public override void Load()
        {
            Kernel.Bind<IReader>().To<ConsoleReaderProvider>();
            Kernel.Bind<IWriter>().To<ConsoleWriterProvider>();
            Kernel.Bind<IParser>().To<CommandParserProvider>();
        }
    }
}
