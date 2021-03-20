using Autofac;

namespace ConsoleApp1
{
    public static class ContainerConfig
    {
        public static IContainer Config()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Calculator>().As<ICalculator>();

            return builder.Build();
        }
    }
}