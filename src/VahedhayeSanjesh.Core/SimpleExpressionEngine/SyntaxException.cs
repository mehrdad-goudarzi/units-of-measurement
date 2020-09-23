using System;

namespace VahedhayeSanjesh.Core.Entities.SimpleExpressionEngine
{
    // Exception for syntax errors
    public class SyntaxException : Exception
    {
        public SyntaxException(string message) 
            : base(message)
        {
        }
    }
}
