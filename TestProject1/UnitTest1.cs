using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly Mock<ConnectionContext> _mockConnectionContext;
        private readonly Mock<ILoggerFactory> _mockLoggerFactory;
        private readonly HubConnectionContext _hubConnectionContext;

        public UnitTest1()
        {
            _mockConnectionContext = new Mock<ConnectionContext>();
            _mockLoggerFactory = new Mock<ILoggerFactory>();
            _hubConnectionContext = new HubConnectionContext(_mockConnectionContext.Object, new HubConnectionContextOptions(), _mockLoggerFactory.Object);
        }

        [Fact]
        public void Test1()
        {
        }
    }
}