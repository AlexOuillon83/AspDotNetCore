using System;
using Xunit;
using Isen.DotNet.Library; 

namespace Isen.DotNet.Tests
{
    public class HelloTest
    {
        [Fact]
        public void World()
        {
            var result = Hello.World; 
            var expected = ("Hello world"); 
            Assert.True(result == expected); 
        }
    }
}
