using Application.Config;
using Application.Interfaces;
using Application.Services;
using Domain;
using Ninject.Modules;
using Service.Interfaces;
using Service.Services;

namespace Application
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IBoardService>().To<BoardService>();
            Bind<IDisplayService>().To<ConsoleDisplayService>();
            Bind<IValidationService>().To<SudokuValidationService>();
            Bind<IInputService>().To<InputService>();
            Bind<ISettings>().To<Settings>();
        }
    }
}
