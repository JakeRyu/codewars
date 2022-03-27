using System.Threading;

namespace codewars.roman_numerals_encoder;

public class RomanConvert
{
    public static string Solution(int n)
    {
        var balance = n;
        var result = "";
        
        var thousandth = balance / 1000;
        balance -= thousandth * 1000;
        result += new string('M', thousandth);

        var hundredth = balance / 100;
        balance -= hundredth * 100;
        result += ToRomanNumerals('C', 'D', 'M', hundredth);

        var tenth = balance / 10;
        balance -= tenth * 10;
        result += ToRomanNumerals('X', 'L', 'C', tenth);

        var oneth = balance;
        result += ToRomanNumerals('I', 'V', 'X', oneth);
        
        return result;
    }

    public static string ToRomanNumerals(char one, char five, char ten, int place)
    {
        return place switch
        {
            0 => "",
            < 4 => new string(one, place),
            4 => $"{one}{five}",
            5 => $"{five}",
            < 9 => $"{five}{new string(one, place - 5)}",
            9 => $"{one}{ten}"
        };
    }
    
    public static string MostVotedSolution(int n)
    {
        string roman = "";
        string[] thousand = {"","M","MM","MMM"};
        string[] hundred = {"","C","CC","CCC","CD","D","DC","DCC","DCCC","CM"};
        string[] ten = {"","X","XX","XXX","XL","L","LX","LXX","LXXX","XC"};
        string[] one = {"","I","II","III","IV","V","VI","VII","VIII","IX"};
  
        roman += thousand[(n/1000)%10];     // 1234/1000%1= 1
        roman += hundred[(n/100)%10];       // 1234/100%10 = 2
        roman += ten[(n/10)%10];            // 1234/10%10 = 3
        roman += one[n%10];                 // 1234%10 = 4
  
        return roman;
    }
}