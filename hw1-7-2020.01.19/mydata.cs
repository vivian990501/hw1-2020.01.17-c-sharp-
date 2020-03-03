using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1_7_2020._01._19
{
    class mydata
    {
        private int _y;
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public int Sat()
        {
            DateTime st = Convert.ToDateTime($"{Y}-01-01");
            DateTime sp = Convert.ToDateTime($"{Y}-01-02");
            int sat = 0;
            if (DateTime.IsLeapYear(Y))
            {
                if (st.DayOfWeek == DayOfWeek.Saturday || sp.DayOfWeek == DayOfWeek.Saturday)
                {
                    sat = 53;
                }
                else
                {
                    sat = 52;
                }
            }
            else
            {
                if (st.DayOfWeek == DayOfWeek.Saturday || sp.DayOfWeek == DayOfWeek.Saturday)
                {
                    sat = 53;
                }
                else
                {
                    sat = 52;
                }
            }
            return sat;
        }
        public int Sun()
        {
            DateTime st = Convert.ToDateTime($"{Y}-01-01 ");
            DateTime sp = Convert.ToDateTime($"{Y}-01-02 ");
            int sun = 0;
            if (DateTime.IsLeapYear(Y))
            {
                if (st.DayOfWeek == DayOfWeek.Sunday || sp.DayOfWeek==DayOfWeek.Sunday)
                {
                    sun = 53;
                }
                else
                {
                    sun = 52;
                }
            }
           
            else
            {
                if (st.DayOfWeek == DayOfWeek.Sunday || sp.DayOfWeek == DayOfWeek.Sunday)
                {
                    sun = 53;
                }
                else
                {
                    sun = 52;
                }
            }
            return sun;
        }
    }
}
