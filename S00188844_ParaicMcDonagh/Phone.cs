using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00188844_ParaicMcDonagh
{
    public class Phone
    {
        
        public double Price { get; set; }
        public string Name { get; set; }
        public string Operating_System { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        //Ex3
        public void IncreasePrice(double StartingPrice, double PercentageValue)
        {
            Price = (StartingPrice * PercentageValue) + StartingPrice;
        }
    }

}

