using System.Text;

namespace RomanNumeralsConverter;

public class RomanNumeralsConverter
{
    private readonly IDictionary<int, string> _numeralsConverter = new Dictionary<int, string>()
    {
        { 1, "I" },
        { 2, "II" },
        { 3, "III" },
        { 4, "IV" },
        { 5, "V" },
        { 6, "VI" },
        { 7, "VII" },
        { 8, "VIII" },
        { 9, "IX" },
        { 10, "X" },
        { 20, "XX" },
        { 30, "XXX" },
        { 40, "XL" },
        { 50, "L" },
        { 60, "LX" },
        { 70, "LXX" },
        { 80, "LXXX" },
        { 90, "XC" },
        { 100, "C" },
        { 200, "CC" },
        { 300, "CCC" },
        { 400, "CD" },
        { 500, "D" },
        { 600, "DC" },
        { 700, "DCC" },
        { 800, "DCCC" },
        { 900, "CM" },
        { 1000, "M" },
        { 2000, "MM" },
        { 3000, "MMM" },
    };

    public string Convert(int number)
    {
        var values = DecomposeInteger(number);

        var romanNumerals = new StringBuilder();
        foreach (var val in values)
        {
            var numeral = _numeralsConverter[val];
            romanNumerals.Append(numeral);
        }

        return romanNumerals.ToString();
    }

    private static IEnumerable<int> DecomposeInteger(int number)
    {
        var str = number.ToString();
        for (int i = 0; i < str.Length; i++)
        {
            var num = int.Parse(str[i].ToString());
            if (num == 0)
            {
                continue;
            }

            var multipler = str.Length - i;

            for (int j = 1; j < multipler; ++j)
            {
                num *= 10;
            }

            yield return num;
        }
    }
}