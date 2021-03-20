using Autofac;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            IContainer container = ContainerConfig.Config();

            using (var scope = container.BeginLifetimeScope())
            {
                ICalculator calculator = scope.Resolve<ICalculator>();

                double sum = calculator.Add(1, 2);
            }
        }
    }
}