using NUnit.Framework;

namespace codewars.multiple_of_3_or_5; 

[TestFixture]
public class Tests {
    [Test]
    public void Test()
    {
        Assert.AreEqual(23, Kata.Solution(10));
    }

    [Test]
    public void WhenNegativeNumber_ShouldReturnZeor() {
        Assert.AreEqual(0, Kata.Solution(-1));
    }
}
