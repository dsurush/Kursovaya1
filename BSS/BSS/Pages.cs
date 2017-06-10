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
        private static TeachersPage _teachersPage = new TeachersPage();
        private static SystemPage _systemPage = new SystemPage();
        private static RedactorPage _redactorPage = new RedactorPage();
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
        public static TeachersPage TeachersPage
        {
            get
            {
                return _teachersPage;
            }
        }
        public static SystemPage SystemPage
        {
            get
            {
                return _systemPage;
            }
        }
        public static RedactorPage RedactorPage
        {
            get
            {
                return _redactorPage;
            }
        }
        
    }
}
