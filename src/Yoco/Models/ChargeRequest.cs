using System.Collections.Generic;
using System.Linq;

namespace Yoco;

public class ChargeRequest
{
    /// <summary>
    /// token generated on the frontend.
    /// eg: tok_DgfdsVFvfbvwjkhdbxv
    /// </summary>
    public string Token { get; }

    /// <summary>
    /// A positive integer representing the amount in cents.
    /// </summary>
    public int AmountInCents { get; }

    /// <summary>
    /// An ISO 4217 currency code
    /// https://en.wikipedia.org/wiki/ISO_4217
    /// </summary>
    public string Currency { get; }

    /// <summary>
    /// A set of key-value pairs that you can attach to a Charge object.
    /// </summary>
    public Dictionary<string, string> Metadata { get; }

    public ChargeRequest(string token, int amountInCents, string currency, Dictionary<string, string> metadata = null)
    {
        Token = token;
        AmountInCents = amountInCents;
        Currency = currency;
        Metadata = metadata;
    }

    public void Validate()
    {
        if (string.IsNullOrEmpty(Token))
        {

        }

        if (string.IsNullOrEmpty(Currency))
        {

        }

        if (Currency.Length != 3)
        {

        }

        if (Currency.All(x => char.IsLetter(x)) == false)
        {

        }

        if (AmountInCents <= 0)
        {

        }
    }
}