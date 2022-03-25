using System.Collections.Generic;
using System.Linq;

namespace codewars.multiple_of_3_or_5; 

public static class Kata {
    public static int Solution(int value) {
        if (value < 0) return 0;

        List<int> numbers = new();
        for (var i = 0; i < value; i++) {
            if(i % 3 == 0 || i % 5 == 0)
                numbers.Add(i);
        }

        return numbers.Sum();
    }

    public static int CleverSolution(int value) {
        return Enumerable.Range(0, value).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
    }
}
