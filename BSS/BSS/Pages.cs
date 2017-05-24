using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSS
{
    static class Pages
    {
        private static StartPage _startPage = new StartPage();
        private static StudentsPage _studentsPage = new StudentsPage();

        public static StartPage StartPage
        {
            get
            {
                return _startPage;
            }
        }

        public static StudentsPage StudentsPage
        {
            get
            {
                return _studentsPage;
            }
        }
    }
}
