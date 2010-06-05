#region

using System.Reflection;
using Breeze.Common.IoC;
using Breeze.Core.Services;
using Castle.Core.Resource;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;

#endregion

namespace Breeze.Core.Bootstrap
{
    public class Bootstrapper
    {
        public static readonly Bootstrapper Instance = new Bootstrapper();

        /// <summary>
        ///   Singleton, use Bootstrapper.Instance
        /// </summary>
        private Bootstrapper()
        {
        }

        public WindsorContainer CreateContainer(params Assembly[] extreaAssemblies)
        {
            var container = new WindsorContainer(new XmlInterpreter(new FileResource("castle.xml")));
                container.AutoWireServicesIn(typeof(IPlayersService).Assembly);

            foreach (Assembly assembly in extreaAssemblies)
            {
                container.AutoWireServicesIn(assembly);
            }

            return container;
        }
    }
}