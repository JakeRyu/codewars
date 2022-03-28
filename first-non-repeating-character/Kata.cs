using System.Linq;

namespace codewars.first_non_repeating_character; 

public class Kata {
    public static string FirstNonRepeatingLetter(string s) {
        // var lowered = s.ToLower();
        // foreach (IGrouping<char,char> grouping in lowered.GroupBy(x => x)) {
        //     if (grouping.Count() != 1) continue;
        //
        //     var key = grouping.Key;
        //     return s.First(x => char.ToLower(x) == key).ToString();
        // }

        return s.GroupBy(char.ToLower)
            .Where(gr => gr.Count() == 1)
            .Select(x => x.First().ToString()) // The first occurence of the repeat. Converted to string to be joined with DefaultIfEmpty("").
            .DefaultIfEmpty("") // If not found, return empty string 
            .First(); // The first letter in the first occurence group
    }
}
