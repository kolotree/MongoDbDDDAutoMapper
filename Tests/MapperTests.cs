using FluentAssertions;
using Xunit;

namespace Tests
{
    public class MapperTests
    {
        [Fact]
        public void first_test_in_the_application() =>
            "SomeString".Should().Be("SomeString");
    }
}