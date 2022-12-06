// Given an integer x, return true if x is a palindrome, and false otherwise.

using System;

public class Solution
{
    public static bool IsPalindrome(int x)
    {
        string number = x.ToString();
        string numberPalindrome = "";

        for (int i = number.Length - 1; i >= 0; i--)
        {
            numberPalindrome += number[i];
        }

        Console.WriteLine(numberPalindrome);

        if (number.Equals(numberPalindrome))
        {
            return true;
        } 
        else
        {
            return false;
        }

    }

    public static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome(121));
    }
}