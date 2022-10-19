using System.Text.RegularExpressions;

namespace Shipwreck.TelephoneNumber;

public static partial class JapaneseTelephoneNumber
{
    public static string Sanitize(string telephoneNo)
    {
        var v = telephoneNo?.TrimOrNull();
        if (v?.Length > 0)
        {
            v = Regex.Replace(v, "[０-９]", m => ((char)(m.Value[0] - '０' + '0')).ToString());
            return Regex.Replace(v, "(\\p{Pc}|\\p{Pd})", "-");
        }
        return v;
    }

    public static string Format(string telephoneNo)
    {
        var c = telephoneNo?.TrimOrNull();
        if (c != null
            && c[0] == '0'
            && long.TryParse(c, out var i))
        {
            return FormatCore(i) ?? c;
        }
        return c;
    }
}
