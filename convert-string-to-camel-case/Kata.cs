using System.Linq;
using System.Text.RegularExpressions;

namespace codewars.convert_string_to_camel_case;

public class Kata
{
    public static string ToCamelCase(string str)
    {
        return string.Concat(str.Split('-','_')
            .Select((s, i) => i > 0 ? char.ToUpper(s[0]) + s.Substring(1) : s)); // i is index of words
    }
    
    public static string ToCamelCaseRegEx(string str)
    {
        
        return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
        // defect: test this: ThE_stEalth-warRior
        
    }
}