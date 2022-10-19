namespace Shipwreck.TelephoneNumber;

public interface ITelephoneNumberFormatInfo
{
    string Sanitize(string telephoneNo);

    string Format(string telephoneNo);
}
