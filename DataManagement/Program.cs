using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S00188844_ParaicMcDonagh;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Phones db = new Phones();

            using (db)
            {
                Phone p1 = new Phone("Samsung S20", 500, "Android", "/images/android.png", "/images/s20.jpg");
                Phone p2 = new Phone("iPhone 11", 600, "IOS", "/images/apple.png", "/images/iphone11.jpg");

                db.phone.Add(p1);
                db.phone.Add(p2);

                Console.WriteLine("Add to Database");

                db.SaveChanges();

                Console.WriteLine("Saved to database");
            }
        }
    }
}
