using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composistion1.Entities
{
    public class HourContract
    {
        public DateTime Date { get; set; }
        public double ValouePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valouePerHour, int hours)
        {
            Date = date;
            ValouePerHour = valouePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValouePerHour;
        }
    }
}
