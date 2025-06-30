using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Interface_Enum
{
    internal class Director : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime BirthYear { get; set; }

        public object Clone()
        {
            return new Director
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                BirthYear = this.BirthYear,
            };
        }

        public override string ToString() 
        {
            return $"{FirstName} {LastName} (born {BirthYear})";
        }
    }
}
