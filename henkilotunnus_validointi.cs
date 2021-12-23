using System.Text.RegularExpressions;

/// <summary>
/// Henkilötunnus validointi. Käyttäjän tarvitsee syöttää henkilötunnus
/// tietyssä formaatissa 6 numeroa + 3 numeroa + 1 kirjain.
/// </summary>

namespace HarjoitusTyo2
{
    public static class henkilotunnus_validointi
    {
        public static bool Matches(this string value, string expression)
        {
            return Regex.IsMatch(value, expression);
        }

        public static bool IsValidSsn(this string value)
        {
            return value.Matches(@"^(?:\d{6}(-|A)\d{3}[0-9|A-Y])$");
        }
    }
}

