using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSS
{
    class Students
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _markmath;

            public int Markmat
        {
            get { return _markmath; }
            set { _markmath = value; }
        }

        public Students(string name, int markmath)
        {
            _name = name;
            _markmath = markmath;
        }
    }
}
