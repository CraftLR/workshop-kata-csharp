using FluentAssertions;

using Xunit;

namespace CraftLR.Exercice1;

public class LeapYearsTest
{
    [Fact]
    public void TestShouldNotBeLeapYearsFor2021()
    {
        Years.IsLeap(2021).Should().BeFalse();
    }
}
