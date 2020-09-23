using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using VahedhayeSanjesh.Core.Exceptions;

namespace VahedhayeSanjesh.Core.Entities.VahedhayeSanjesh
{
    // فرمول تبدیل
    public class FormoleTabdil : ValueObject
    {
        private const string RegExpression = @"[0-9a*+/-\(\)]*";
        public FormoleTabdil(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                throw new EmptyFormoleTabdilException();

            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                throw new EmptyFormoleTabdilException();

            if (!Regex.IsMatch(value, RegExpression))
                throw new InvalidFormoleTabdilException();

            if (!IsBalanced(value))
                throw new InvalidFormoleTabdilException();

            Value = value;
        }

        public string Value { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }

        public static bool IsBalanced(string input)
        {
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>() { { '(', ')' } };

            Stack<char> brackets = new Stack<char>();

            try
            {
                // Iterate through each character in the input string
                foreach (char c in input)
                {
                    // check if the character is one of the 'opening' brackets
                    if (bracketPairs.Keys.Contains(c))
                    {
                        // if yes, push to stack
                        brackets.Push(c);
                    }
                    else
                        // check if the character is one of the 'closing' brackets
                        if (bracketPairs.Values.Contains(c))
                    {
                        // check if the closing bracket matches the 'latest' 'opening' bracket
                        if (c == bracketPairs[brackets.First()])
                        {
                            brackets.Pop();
                        }
                        else
                            // if not, its an unbalanced string
                            return false;
                    }
                    else
                        // continue looking
                        continue;
                }
            }
            catch
            {
                // an exception will be caught in case a closing bracket is found, 
                // before any opening bracket.
                // that implies, the string is not balanced. Return false
                return false;
            }

            // Ensure all brackets are closed
            return brackets.Count() == 0 ? true : false;
        }
    }
}