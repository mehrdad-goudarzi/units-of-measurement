using VahedhayeSanjesh.Core.Entities.SimpleExpressionEngine;

namespace VahedhayeSanjesh.Core.Entities.VahedeSanjeshAggregate
{
    public static class FormolProccessor
    {
        public static double Proccess(FormoleTabdil formol, double value)
        {
            string exp = formol.Value.Replace("a", value.ToString());
            double result = Parser.Parse(exp).Eval(null);

            return result;
        }
    }
}