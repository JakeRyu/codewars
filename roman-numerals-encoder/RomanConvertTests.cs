using NUnit.Framework;

namespace codewars.roman_numerals_encoder;

[TestFixture]
public class RomanConvertTests
{
    [TestCase(1, "I")]
    [TestCase(2, "II")]
    [TestCase(4, "IV")]
    [TestCase(100, "C")]
    [TestCase(200, "CC")]
    [TestCase(400, "CD")]
    [TestCase(500, "D")]
    [TestCase(600, "DC")]
    [TestCase(900, "CM")]
    [TestCase(500, "D")]
    [TestCase(1000, "M")]
    [TestCase(2000, "MM")]
    [TestCase(4000, "MMMM")]
    [TestCase(1954, "MCMLIV")]
    [TestCase(1990, "MCMXC")]
    [TestCase(2008, "MMVIII")]
    [TestCase(2014, "MMXIV")]
    public void Test(int value, string expected)
    {
        Assert.AreEqual(expected, RomanConvert.Solution(value));
    }
    
    [TestCase('I', 'V', 'X', 1, "I")]
    [TestCase('I', 'V', 'X', 2, "II")]
    [TestCase('I', 'V', 'X', 3, "III")]
    [TestCase('I', 'V', 'X', 4, "IV")]
    [TestCase('I', 'V', 'X', 5, "V")]
    [TestCase('I', 'V', 'X', 6, "VI")]
    [TestCase('I', 'V', 'X', 7, "VII")]
    [TestCase('I', 'V', 'X', 8, "VIII")]
    [TestCase('I', 'V', 'X', 9, "IX")]
    // [TestCase('I', 'V', 'X', 10, "X")]
    public void TestRomanSystem(char first, char fifth, char tenth, int place, string expected)
    {
        Assert.AreEqual(expected, RomanConvert.ToRomanNumerals('I', 'V', 'X', place));
    }

    [TestCase(1, "I")]
    [TestCase(2, "II")]
    [TestCase(4, "IV")]
    [TestCase(100, "C")]
    [TestCase(200, "CC")]
    [TestCase(400, "CD")]
    [TestCase(500, "D")]
    [TestCase(600, "DC")]
    [TestCase(900, "CM")]
    [TestCase(500, "D")]
    [TestCase(1000, "M")]
    [TestCase(2000, "MM")]
    [TestCase(1954, "MCMLIV")]
    [TestCase(1990, "MCMXC")]
    [TestCase(2008, "MMVIII")]
    [TestCase(2014, "MMXIV")]
    public void TestMostVotedSolution(int value, string expected)
    {
        Assert.AreEqual(expected, RomanConvert.MostVotedSolution(value));
    }
}