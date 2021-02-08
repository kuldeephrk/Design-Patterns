using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Iterator
{
    public class LAPaperIterator : IIterator
    {
        private readonly string[] _reporters;
        private int _current;

        public LAPaperIterator(string[] reporters)
        {
            _reporters = reporters;
            _current = 0;
        }
        public string CurrentItem()
        {
            return _reporters[_current];
        }

        public void First()
        {
            _current = 0;
        }

        public bool IsDone()
        {
            return _current >= _reporters.Length;
        }

        public string Next()
        {
            return _reporters[_current++];
        }
    }
}
