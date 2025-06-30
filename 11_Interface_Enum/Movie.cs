using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Interface_Enum
{
    public enum Genre
    {
        Action,
        Comedy,
        Drama,
        Horror,
        SciFi,
        Documentary,
        Romance

    }
    internal class Movie: ICloneable, IComparable
    {
        public string Title {  get; set; }
        public string Description { get; set; }
        public Director Director { get; set; }
        public string Country { get; set; }
        public  Genre Genre { get; set; }
        public int Year {  get; set; }
        public double Raiting { get; set; }


    }
}
