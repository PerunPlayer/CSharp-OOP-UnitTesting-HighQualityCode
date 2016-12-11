using System;

using Dealership.Contracts;
using Dealership.Contracts.Comments;
using Dealership.Contracts.Engine;
using Dealership.Contracts.Factories;
using Dealership.Contracts.Handlers;
using Dealership.Contracts.IO;
using Dealership.Contracts.Vehicles;

using Dealership.Engine;

using Dealership.Handlers.CommandHandlers;
using Dealership.IO;

using Dealership.Models;

using Ninject;
using Ninject.Activation;
using Ninject.Extensions.Factory;
using Ninject.Modules;

namespace Dealership.Config
{
    public class EngineModuleBinding : NinjectModule
    {
        public override void Load()
        {
            this.Kernel.Bind<IReader>().To<ConsoleReader>().InSingletonScope();
            this.Kernel.Bind<IWriter>().To<ConsoleWriter>().InSingletonScope();
            this.Kernel.Bind<IEngine>().To<DealershipEngine>().InSingletonScope();

            this.Kernel.Bind<ITruck>().To<Truck>();
            this.Kernel.Bind<IMotorcycle>().To<Motorcycle>();
            this.Kernel.Bind<ICar>().To<Car>();
            this.Kernel.Bind<IUser>().To<User>();
            this.Kernel.Bind<ICommand>().To<Command>();
            this.Kernel.Bind<IComment>().To<Comment>();

            this.Bind<IDealershipFactory>().ToFactory();

            this.Kernel.Bind<ICommandHandler>().To<AddCommentCommandHandler>();
            this.Kernel.Bind<ICommandHandler>().To<AddVehicleCommandHandler>();
            this.Kernel.Bind<ICommandHandler>().To<LoginCommandHandler>();
            this.Kernel.Bind<ICommandHandler>().To<LogoutCommandHandler>();
            this.Kernel.Bind<ICommandHandler>().To<RegisterCommandHandler>();
            this.Kernel.Bind<ICommandHandler>().To<RemoveCommentCommandHandler>();
            this.Kernel.Bind<ICommandHandler>().To<RemoveVehicleCommandHandler>();
            this.Kernel.Bind<ICommandHandler>().To<ShowUsersCommandHandler>();
            this.Kernel.Bind<ICommandHandler>().To<ShowVehiclesCommandHandler>();
            this.Kernel
                .Bind<ICommandHandler>()
                .ToMethod(this.SetupResponsibilityChain(this.Kernel))
                .WhenInjectedInto<IEngine>();
        }

        private Func<IContext, ICommandHandler> SetupResponsibilityChain(IKernel kernel)
        {
            return context =>
            {
                var addCommentHandler = kernel.Get<AddCommentCommandHandler>();
                var addVehicleHandler = kernel.Get<AddVehicleCommandHandler>();
                var loginHandler = kernel.Get<LoginCommandHandler>();
                var logoutHandler = kernel.Get<LogoutCommandHandler>();
                var registerHandler = kernel.Get<RegisterCommandHandler>();
                var removeCommentHandler = kernel.Get<AddCommentCommandHandler>();
                var removeVehicleHandler = kernel.Get<RemoveVehicleCommandHandler>();
                var showUsersHandler = kernel.Get<ShowUsersCommandHandler>();
                var showVehiclesHandler = kernel.Get<ShowVehiclesCommandHandler>();

                registerHandler.SetSuccessor(loginHandler);
                loginHandler.SetSuccessor(logoutHandler);
                logoutHandler.SetSuccessor(addVehicleHandler);
                addVehicleHandler.SetSuccessor(removeVehicleHandler);
                removeVehicleHandler.SetSuccessor(addCommentHandler);
                addCommentHandler.SetSuccessor(removeCommentHandler);
                removeCommentHandler.SetSuccessor(showUsersHandler);
                showUsersHandler.SetSuccessor(showVehiclesHandler);

                return registerHandler;
            };
        }
    }
}