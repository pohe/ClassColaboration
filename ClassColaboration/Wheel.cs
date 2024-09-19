using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassColaboration
{
    public class Wheel
    {

        public int Year { get; set; }

        public string Type { get; set; }

        public double Co2 { get; set; }

        public Wheel(int year, string type, double co2)
        {
            Year = year;
            Type = type;
            Co2 = co2;
        }

        public override string ToString()
        {
            return $"Year: {Year}, Type: {Type}, Production CO2: {Co2}";
        }
    }

}
