using System;
using Autofac.Extras.Moq;
using ConsoleApp1;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            using (var mock = AutoMock.GetStrict())
            {
                mock.Mock<ICalculator>()
                    .Setup(x => x.Add(1, 2))
                    .Returns(3);

                ICalculator calculator = mock.Create<ICalculator>();
                
                var sum = calculator.Add(1, 2);
                Assert.Equal(expected:3, actual:sum);
            }
        }
    }
}