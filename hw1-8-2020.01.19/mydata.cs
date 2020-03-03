using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1_8_2020._01._19
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
            DateTime sp = Convert.ToDateTime($"{Y}-12-31");
            int sat = 0;
            while (st <= sp)
            {
                if (st.DayOfWeek == DayOfWeek.Saturday)
                {
                    sat++;

                }
                st = st.AddDays(1);
            }
            return sat;
        }
        public int Sun()
        {
            DateTime st = Convert.ToDateTime($"{Y}-01-01 ");
            DateTime sp = Convert.ToDateTime($"{Y}-12-31 ");
            int sun = 0;
            while (st <= sp)
            {
                if (st.DayOfWeek == DayOfWeek.Sunday)
                {
                    sun++;

                }
                st = st.AddDays(1);
            }
            return sun;
        }
    }
}
