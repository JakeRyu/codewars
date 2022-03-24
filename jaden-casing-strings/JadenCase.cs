using System.Globalization;
using System.Linq;

namespace codewars.jaden_casing_strings; 

public static class JadenCase {
    public static string ToJadenCase(this string phrase) {
        var words = phrase.Split();

        return string.Join(' ', words.Select(word =>  char.ToUpper(word[0]) + word[1..]));
        
        // Clever solution
        // return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
    }
}
