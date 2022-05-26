using System;

class PermutationChallengeDOW
{
    public static void Permutation(String testStr, int l, int r)
    {
        if (l != r)
        {
            for (int i = 0; i <= r; i++)
            {
                testStr = Swap(testStr, l, i);
                Permutation(testStr, l + 1, r);
                testStr = Swap(testStr, l, i);
            }
        }
        else
        {
            Console.WriteLine(testStr);
        }
    }
    public static String Swap(String to, int x, int y)
    {
        char[] testCharArr = to.ToCharArray();

        // Swapping Index Of Characters ( X -> Y ),( Y -> X )
        (testCharArr[y], testCharArr[x]) = (testCharArr[x], testCharArr[y]);
        string final = new(testCharArr);
        return final;
    }
    public static void Main()
    {
        Console.WriteLine("Enter String\n");
        var str = Console.ReadLine();
        Console.WriteLine("Total Permutations Of {0} Below: \n", str);
        var len = str.Length;
        Permutation(str, 0, len - 1);
    }
}