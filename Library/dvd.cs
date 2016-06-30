using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class dvd : Media
    {
        public override int RentalLength
        {
            get
            {
                return 7;
            }
            //Ze set mezod, it does nozing!
            set
            {
                
            }
        }

        public override void PrintMediaDetails()
        {
            Console.WriteLine("DVD, {0}, ({1})",Title, Length);
            Console.WriteLine("Rented on: {0}",RentedDate);
            Console.WriteLine("Due on: {0}", ReturnDueDate());
        }

        

        public override DateTime ReturnDueDate()
        {
            return RentedDate.AddDays(RentalLength);
        }
    }
}
