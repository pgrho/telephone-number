namespace Shipwreck.TelephoneNumber;

public class JapaneseTelephoneNumberTest
{
    [Theory]
    [InlineData("09012345678", "090-1234-5678")]
    [InlineData("0120123456", "0120-123-456")]
    [InlineData("0312345678", "03-1234-5678")]
    [InlineData("0137123456", "0137-12-3456")]
    [InlineData("0137712345", "01377-1-2345")]
    public void FormatTest(string args, string expected)
    {
        Assert.Equal(expected, JapaneseTelephoneNumber.Format(args));
    }
}