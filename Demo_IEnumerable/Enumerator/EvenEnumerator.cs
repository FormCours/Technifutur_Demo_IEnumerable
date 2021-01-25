using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_IEnumerable.Enumerator
{
    public class EvenEnumerator : IEnumerator<int>
    {
        public int MinValue { get; internal set; }
        public int MaxValue { get; internal set; }
        private int Step { get; }

        public EvenEnumerator(int minValue = 0, int maxValue = 10)
        {
            MinValue = minValue;
            MaxValue = maxValue;

            Step = 2;
            Current = minValue - Step;
        }

        public int Current { get; private set; }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public void Dispose()
        { }

        public bool MoveNext()
        {
            Current += Step;
            return Current <= MaxValue;
        }

        public void Reset()
        {
            Current = MinValue - Step;
        }
    }
}
