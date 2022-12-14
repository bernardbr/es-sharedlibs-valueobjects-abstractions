using System.Diagnostics.CodeAnalysis;

namespace Es.SharedLibs.ValueObjects.Abstractions.UnitTests.Stubs;

[ExcludeFromCodeCoverage]
public class ZipCodeStub : ValueObject
{
    public ZipCodeStub(string code, CountryStub country)
    {
        if (string.IsNullOrWhiteSpace(code))
        {
            throw new ArgumentNullException(nameof(code));
        }

        Code = code;
        Country = country;
    }

    public string Code { get; }
    public CountryStub Country { get; }

    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return Code;
        yield return Country;
    }
}
