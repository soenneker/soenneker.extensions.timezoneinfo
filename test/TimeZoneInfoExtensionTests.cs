using FluentAssertions;
using Soenneker.Utils.TimeZones;
using Xunit;

namespace Soenneker.Extensions.TimeZoneInfo.Tests;

public class TimeZoneInfoExtensionTests
{
    [Fact]
    public void ToSimpleAbbreviation_Returns_ET_For_Eastern_Standard_Time()
    {
        // Arrange
        var tz = Tz.Eastern;

        // Act
        var abbreviation = tz.ToSimpleAbbreviation();

        // Assert
        abbreviation.Should().Be("ET");
    }
}