using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassColaboration
{
    public class Car
    {
        public string ModelName { get; set; }
        public double Co2FromProduction { get; set; }

        public Car(string modelName, double co2FromProduction)
        {
            ModelName = modelName;
            Co2FromProduction = co2FromProduction;
        }

        public void Start()
        {

        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
