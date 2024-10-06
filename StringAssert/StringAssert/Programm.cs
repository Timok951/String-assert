using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Programm
{
    public class StringAsserts
    {
        public string ShortestWord(string input)
        {

            return input.Split(new[] { ' ', ',', '.', '!' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(word => word.Length)
                .FirstOrDefault();
        }

        public int CountWord(string input)
        {
            return string.IsNullOrWhiteSpace(input) ? 0 : input.Split(new[] { ' ', '.', ',', '!' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public int CountCharacter(string input)
        {
            return input.Length ;
        }

        public char FindNinthCharacter(string input)
        {
            if (string.IsNullOrWhiteSpace(input) || input.Length < 9)
            {
                throw new ArgumentException("Длина строки должна быть не менее 9 символов.");
            }

            return input[8];
        }

        public int CountDigits(string input)
        {
            return input.Count(char.IsDigit);
        }

        public int LongestNumbers(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return 0;

            var match = Regex.Matches(input, @"\d+");
            return match.Count > 0 ? match.Cast<Match>().Max(m => m.Value.Length) : 0;
        }

        public int CountSubstrings(string input)
        {
            if (string.IsNullOrEmpty(input)) return 0;

            return Regex.Matches(input, "am", RegexOptions.IgnoreCase).Count;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {

        }

    }

    }

