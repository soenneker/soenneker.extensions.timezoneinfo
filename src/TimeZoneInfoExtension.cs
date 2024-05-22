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
    /// for any time zone not explicitly handled in the method's implementation. Supports IANA.
    /// </remarks>
    public static string ToSimpleAbbreviation(this System.TimeZoneInfo timeZone)
    {
        return timeZone.Id switch
        {
            "Eastern Standard Time" or "America/New_York" => "ET",
            "Central Standard Time" or "America/Chicago" => "CT",
            "Mountain Standard Time" or "America/Denver" => "MT",
            "Pacific Standard Time" or "America/Los_Angeles" => "PT",
            _ => "Unknown"
        };
    }
}
