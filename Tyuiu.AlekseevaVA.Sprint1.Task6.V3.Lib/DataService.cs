using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AlekseevaVA.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string LastLetterWord(string value)
        {
            value = value.Trim();
            if (string.IsNullOrEmpty(value))
                return string.Empty;

            return string.Concat(value.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                     .Select(word => word[^1]));
        }
    }
}
