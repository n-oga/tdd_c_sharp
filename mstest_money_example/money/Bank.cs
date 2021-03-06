using System.Collections.Generic;

namespace mstest_money_example.money
{
    public class Bank
    {
        private readonly Dictionary<Pair, int> _rates = new Dictionary<Pair, int>();
        public Money Reduce(Expression source, string to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string from, string to, int rate)
        {
            _rates.Add(new Pair(from, to), rate);
        }

        public int Rate(string from, string to)
        {
            return @from.Equals(to) ? 1 : _rates[new Pair(@from, to)];
        }
    }
}