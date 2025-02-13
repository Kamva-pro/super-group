using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static string IsMagicalPotion(int power)
    {
        int cubeRoot = (int)Math.Cbrt(power);
        return (cubeRoot * cubeRoot * cubeRoot == power) ? "YES" : "NO";
    }

    // Sneaky Outcomes
    static int[] FindDuplicates(int[] outcomes)
    {
        List<int> duplicates = new List<int>();
        HashSet<int> seen = new HashSet<int>();

        foreach (int num in outcomes)
        {
            if (seen.Contains(num) && !duplicates.Contains(num))
                duplicates.Add(num);
            seen.Add(num);
        }
        return duplicates.ToArray();
    }

    // Reformat String to Alternating Case
    static string AlternateCase(string s)
    {
        char[] result = s.ToCharArray();
        for (int i = 0; i < result.Length; i++)
        {
            if (char.IsLetter(result[i]))
            {
                result[i] = (i % 2 == 0) ? char.ToUpper(result[i]) : char.ToLower(result[i]);
            }
        }
        return new string(result);
    }

    // Organizing Books into Identical Sets
    static string CanOrganizeBooks(int[] shelf)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (int book in shelf)
        {
            if (freq.ContainsKey(book))
                freq[book]++;
            else
                freq[book] = 1;
        }

        int minCount = freq.Values.Min();
        return freq.Values.All(count => count % minCount == 0) ? "YES" : "NO";
    }

    static void Main()
    {

        Console.WriteLine(IsMagicalPotion(27)); 
        Console.WriteLine(IsMagicalPotion(30));  
        Console.WriteLine(string.Join(", ", FindDuplicates(new int[] {0, 3, 2, 1, 3, 2}))); 
        Console.WriteLine(AlternateCase("hello world!"));  
        Console.WriteLine(CanOrganizeBooks(new int[] {5, 5, 3, 3, 2, 2}));  
    }
}
