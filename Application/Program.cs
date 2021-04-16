using Application.Config;
using Application.Interfaces;
using Ninject;
using System.Reflection;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var settings = kernel.Get<ISettings>();
            settings.Configure();

            var consoleDisplayService = kernel.Get<IDisplayService>();
            consoleDisplayService.InitializeDisplay();
        }
    }
}
