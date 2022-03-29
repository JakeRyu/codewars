namespace codewars.create_phone_number; 

public class Kata {
    public static string CreatePhoneNumber(int[] n) {
        return $"({n[0]}{n[1]}{n[2]}) {n[3]}{n[4]}{n[5]}-{n[6]}{n[7]}{n[8]}{n[9]}";
    }

    public static string CleverSolution(int[] numbers) {
        return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
    }
}
