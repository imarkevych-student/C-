using System;

namespace _04_01_IntroOOP_Classwork
{
    public partial class Freezer
    {
        private string model;
        private double capacity;
        private int temperature;
        private bool hasNoFrost;
        private string energyClass;

        private static int totalFreezers;
        private static string defaultBrand;

        public string Model
        {
            get { return model; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                    model = value;
                else
                    model = "Unknown"; 
            }
        }

        public double Capacity
        {
            get { return capacity; }
            set
            {
                if (value > 0)
                    capacity = value;
                else
                    capacity = 100;
            }
        }

        public int Temperature
        {
            get { return temperature; }
            set
            {
                if (value < -40 || value >0)
                    Console.WriteLine("Неприпустима температура!");
                else
                    temperature = value;
            }
        }

        public bool HasNoFrost
        {
            get { return hasNoFrost; }
            set { hasNoFrost = value; }
        }
        public string EnergyClass
        {
            get { return energyClass; }
            set { energyClass = value; }
        }
        
        static Freezer()
        {
            totalFreezers = 0;
            defaultBrand = "GeneraicBrand";
        }
        public Freezer() : this("Unknown", 200, -18, true, "A++") { }

        public Freezer(string model, double capacity, int temperature, bool hasNoFrost, string eneryClass)
        {
            Model = model;
            Capacity = capacity;
            Temperature = temperature;
            HasNoFrost  = hasNoFrost;
            EnergyClass = eneryClass;
            totalFreezers++;
        }
        public override string ToString()
        {
            return $"Модель: {Model}, Об'єм: {Capacity} л, Темпаература: {Temperature} C, NoFrost: {HasNoFrost}, Клас енергоефективності: {EnergyClass}";
        }
    } 
}
