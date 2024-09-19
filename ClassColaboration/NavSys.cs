using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassColaboration
{
    public class NavSys
    {
        #region Properties
        public string Producer { get; set; }
        public string DisplayType { get; set; }
        public string Description { get; set; }
        public double Co2FromProduction { get; set; }
        #endregion

        #region Constructors
        public NavSys(string producer, string displayType, string description, double co2FromProduction)
        { //constructor must have same name as file
            Producer = producer;
            DisplayType = displayType;
            Description = description;
            Co2FromProduction = co2FromProduction;
        }
        #endregion

        #region Methods
        public void Start()
        {
            Console.WriteLine("NavSys har startet");
        }
        #endregion

    }
}

