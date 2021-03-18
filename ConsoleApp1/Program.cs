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

    public static class ContainerConfig
    {
        public static IContainer Config()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Calculator>().As<ICalculator>();

            return builder.Build();
        }
    }

    public interface ICalculator
    {
        double Add(double x, double y);
    }

    public class Calculator : ICalculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
    }
}