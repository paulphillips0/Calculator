using System;
using Autofac.Extras.Moq;
using ConsoleApp1;
using Moq;
using Moq.Language.Flow;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly ICalculator _calculator;

        public UnitTest1()
        {
            AutoMock mock = AutoMock.GetStrict();

            mock.Mock<ICalculator>()
                .Setup(x => x.Add(1, 2))
                .Returns(3);

            _calculator = mock.Create<ICalculator>();
        }

        [Fact]
        public void Test1()
        {
            var sum = _calculator.Add(1, 2);
            Assert.Equal(expected: 3, actual: sum);
        }
    }
}