using System.Collections.Generic;

namespace RomanNumeralsConverter;

public class RomanNumeralsConverter
{
    private readonly HashSet<string> _symbolTable = new HashSet<string>()
    {
        "I", "V", "X", "L", "C", "D", "M"
    };

    public string Convert(int number)
    {
        var str = number.ToString();

        var tokenPosition = 1;

        var tokens = new List<int>();

        for (int i = 0; i < str.Length; i++)
        {
            var num = int.Parse(str[i].ToString());
            var multipler = str.Length - i;

            for (int j = 1; j < multipler; ++j)
            {
                num *= 10;
            }

            tokens.Add(num);
        }

        throw new NotImplementedException();
    }
}