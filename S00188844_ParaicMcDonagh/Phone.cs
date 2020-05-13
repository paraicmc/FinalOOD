using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00188844_ParaicMcDonagh
{
    public class Phone
    {
        public Phone(string v1, int v2, string v3, string v4, string v5)
        {
        }

        public double Price { get; set; }
        public string Name { get; set; }
        public string Operating_System { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        public virtual List<Phone> phone { get; set; }

       
    //Ex3
    public void IncreasePrice(double StartingPrice, double PercentageValue)
    {
        Price = (StartingPrice * PercentageValue) + StartingPrice;
    }
    }

    public class Phones : DbContext
    {
        public Phones() : base("New Phones") { }

        public DbSet<Phone> phone { get; set; }
    }


}


