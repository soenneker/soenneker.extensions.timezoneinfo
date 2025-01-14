using System;
using System.Collections.Generic;

namespace Soenneker.Extensions.TimeZoneInfo;

/// <summary>
/// A collection of helpful TimeZoneInfo extension methods
/// </summary>
public static class TimeZoneInfoExtension
{
    private static readonly Dictionary<string, string> _timeZoneAbbreviations = new(StringComparer.OrdinalIgnoreCase)
    {
        { "Eastern Standard Time", "ET" },
        { "America/New_York", "ET" },
        { "Central Standard Time", "CT" },
        { "America/Chicago", "CT" },
        { "Mountain Standard Time", "MT" },
        { "America/Denver", "MT" },
        { "Pacific Standard Time", "PT" },
        { "America/Los_Angeles", "PT" }
    };

    /// <summary>
    /// Converts a TimeZoneInfo to its corresponding simple abbreviation.
    /// </summary>
    /// <param name="timeZone">The TimeZoneInfo instance.</param>
    /// <returns>The abbreviation (e.g., "ET", "CT", "MT", "PT"), or "Unknown" if the time zone is not recognized.</returns>
    public static string ToSimpleAbbreviation(this System.TimeZoneInfo timeZone)
    {
        return _timeZoneAbbreviations.GetValueOrDefault(timeZone.Id, "Unknown");
    }
}
