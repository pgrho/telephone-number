namespace Shipwreck.TelephoneNumber;

internal static class StringHelper
{
    public static string TrimOrNull(this string s)
        => string.IsNullOrWhiteSpace(s) ? null : s.Trim();
}
