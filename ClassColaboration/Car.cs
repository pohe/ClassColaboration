using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassColaboration
{
    public class Car
    {
        //instance fields
        private Engine _theEngine;
        private NavSys _theNavsys;
        private Wheel _theWheel;

        public Engine TheEngine{
            get { return _theEngine; }

        }

        public NavSys TheNaviSys
        {
            get { return _theNavsys; }
        }

        public Wheel TheWheel
        {
            get { return _theWheel; }
        }

        public string ModelName { get; set; }
        public double Co2FromProduction { get; set; }

        public Car(string modelName, double co2FromProduction)
        {
            ModelName = modelName;
            Co2FromProduction = co2FromProduction;
            _theEngine = new Engine(120, "Gasoline", 2000);
            _theNavsys = new NavSys("Garmin", "Touch", "Covers EU", 4000);
            _theWheel = new Wheel(2024, "Winter", 500);
        }


        public void ChangeWheel(Wheel wheel)
        {
            _theWheel = wheel;
        }
        public void Start()
        {
            Console.WriteLine("Bilens startes");
            _theEngine.Start();
            _theNavsys.Start();
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
