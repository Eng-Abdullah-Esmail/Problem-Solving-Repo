using System;

class Program
{
    static string LongestPalindromicSubstring(string input)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        int maxLength = 1;  // Length of the longest palindromic substring found
        int start = 0;     // Starting index of the longest palindromic substring

        // Iterate through each character in the input string
        for (int i = 0; i < input.Length; i++)
        {
            // Check for odd-length palindromes with the current character as the center
            int len1 = ExpandPalindrome(input, i, i);
            // Check for even-length palindromes with the current and next characters as the center
            int len2 = ExpandPalindrome(input, i, i + 1);

            // Determine the length and starting index of the longest palindromic substring
            int len = Math.Max(len1, len2);
            if (len > maxLength)
            {
                maxLength = len;
                start = i - (len - 1) / 2;
            }
        }

        // Extract the longest palindromic substring from the input string
        return input.Substring(start, maxLength);
    }

    static int ExpandPalindrome(string input, int left, int right)
    {
        // Expand the palindrome by moving the left and right pointers outward
        while (left >= 0 && right < input.Length && input[left] == input[right])
        {
            left--;
            right++;
        }

        // Return the length of the palindrome
        return right - left - 1;
    }

    static void Main()
    {
        string input = "babad";
        string longestPalindrome = LongestPalindromicSubstring(input);

        Console.WriteLine("Longest palindromic substring: " + longestPalindrome);

        Console.ReadKey();
    
    }
}