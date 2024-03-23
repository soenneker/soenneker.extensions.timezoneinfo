using System;

namespace Soenneker.Extensions.TimeZoneInfo;

/// <summary>
/// A collection of helpful TimeZoneInfo extension methods
/// </summary>
public static class TimeZoneInfoExtension
{
    /// <summary>
    /// Gets a simplified time zone abbreviation based on the time zone's identifier.
    /// </summary>
    /// <param name="timeZone">The <see cref="TimeZoneInfo"/> instance to get the abbreviation for.</param>
    /// <returns>A string representing the simplified abbreviation of the time zone. For example, "ET" for Eastern Time.</returns>
    /// <exception cref="NullReferenceException">Thrown if <paramref name="timeZone"/> is null.</exception>
    /// <remarks>
    /// This method provides a simple abbreviation for a limited set of time zones based on their identifiers. 
    /// It does not differentiate between Standard Time and Daylight Saving Time. The method returns "Unknown" 
    /// for any time zone not explicitly handled in the method's implementation.
    /// </remarks>
    public static string GetSimpleAbbreviation(this System.TimeZoneInfo timeZone)
    {
        return timeZone.Id switch
        {
            "Eastern Standard Time" => "ET",
            "Central Standard Time" => "CT",
            "Mountain Standard Time" => "MT",
            "Pacific Standard Time" => "PT",
            _ => "Unknown"
        };
    }
}
