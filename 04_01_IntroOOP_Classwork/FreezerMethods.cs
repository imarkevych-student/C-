using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01_IntroOOP_Classwork
{
    public partial class Freezer
    {
        public static int GetTotalFreezers()
        {
            return totalFreezers;
        }

        public static void SetDefaultBrand(string brand)
        {
            if (!string.IsNullOrEmpty(brand))
            {
                defaultBrand = brand;
            }
            else
            {
                defaultBrand = "GenericBrand";
            }
        }

    }
}
